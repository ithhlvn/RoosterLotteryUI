using Client.Services;
using RoosterLottery.Models;
using System.Numerics;

namespace RoosterLotteryUI
{
    public partial class FrmRoosterLottery : Form
    {
        #region Fields
        private int _tickCount;
        private Player CurrenrPlayer = new();
        #endregion
        #region Constructors
        public FrmRoosterLottery()
        {
            InitializeComponent();
            gbInputInfo.Enabled = false;
            // Initialize the timer
            timerTick.Interval = 1000; // 1 second intervals
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start(); // Start the timer

            _tickCount = 0; // Initialize tick count
        }

        public FrmRoosterLottery(Player player) : this()
        {
            SetInfo(player);
            CurrenrPlayer = player;
        }
        #endregion

        #region Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == (Keys.Alt | Keys.S))
                {
                    btnSearch.PerformClick();
                    return true;
                }
                else if (keyData == (Keys.Control | Keys.Q))
                {
                    this.Dispose();
                    return true;
                }
            }
            catch { }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ReloadBetHistory()
        {
            BetService betService = new();
            var bets = betService.GetByPlayerId(CurrenrPlayer.Id);
            dgvBet.DataSource = bets;
        }
        private void SetInfo(Player? player)
        {
            if (player == null)
            {
                txtFullName.Text = null;
                dtpDoB.CustomFormat = " ";
                dtpDoB.Format = DateTimePickerFormat.Custom;
                txtPhoneNumber.Text = null;
                txtSearchPhone.Text = null;
                dgvBet.DataSource = null;
                return;
            }
            CurrenrPlayer = player;
            txtFullName.Text = player.FullName;
            dtpDoB.Value = (DateTime)player?.DoB;
            txtPhoneNumber.Text = txtSearchPhone.Text = player.Phone;
            ReloadBetHistory();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()) == false)
                {
                    PlayerService playerService = new();
                    var player = await playerService.SearchPlayerByPhoneNumber(txtPhoneNumber.Text.Trim());
                    gbInputInfo.Enabled = player != null;
                    SetInfo(player);
                }
            }
            catch
            {
                throw;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Save Player data?", "Confirm Save!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PlayerService playerService = new();

                    Player player = new Player { FullName = txtFullName.Text.Trim(), DoB = (DateTime)dtpDoB.Value, Phone = txtPhoneNumber.Text.Trim() };

                    await playerService.Save(player);
                }
                else
                {
                    // If 'No', do something here.
                }
            }
            catch
            {
                throw;
            }
        }

        private async void BtnBet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Save Bet data?", "Confirm Save!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BetService betService = new();

                    Bet bet = new Bet { OnDate = DateTime.Now, PlayerId = CurrenrPlayer.Id, SlotId = (int)nudSlot.Value, Value = (byte)nudBet.Value, IsWin = false };
                    await betService.Save(bet);
                    ReloadBetHistory();
                    MessageBox.Show("Bet Inserted Successfully!");
                }
                else
                {
                    // If 'No', do something here.
                }
            }
            catch
            {
                throw;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit Application?",
                                     "Confirm Exit!!",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void TimerTick_Tick(object sender, EventArgs e)
        {
            lblTimeTick.Text = DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss");
        }
        #endregion

        private void BtnAddSlot_Click(object sender, EventArgs e)
        {
            FrmSlot frmSlot = new();
            using (frmSlot)
            {
                //this.Hide();
                frmSlot.ShowDialog();
                frmSlot.Dispose();
            }
        }
    }
}
