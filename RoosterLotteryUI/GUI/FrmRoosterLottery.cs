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
                if (keyData == (Keys.Control | Keys.S))
                {
                    btnSearch.PerformClick();
                    return true;
                }
                if (keyData == (Keys.Control | Keys.A))
                {
                    btnAddSlot.PerformClick();
                    return true;
                }
                if (keyData == (Keys.Control | Keys.B))
                {
                    btnBet.PerformClick();
                    return true;
                }
                if (keyData == (Keys.Control | Keys.L))
                {
                    btnLottery.PerformClick();
                    return true;
                }
                if (keyData == (Keys.Control | Keys.E))
                {
                    btnExit.PerformClick();
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
            dtpDoB.Value = (DateTime)player.DoB.Value;
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
                    SetInfo(player);
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

        private async void BtnBet_Click(object sender, EventArgs e)
        {
            try
            {
                string strValid = CheckValidInput();
                if (!string.IsNullOrEmpty(strValid))
                {
                    MessageBox.Show(strValid);
                    return;
                }
                await SaveBet();
            }
            catch
            {
                throw;
            }
        }

        static int GetTimeBlock(TimeSpan time)
        {
            // Each hour is one block, so we can just return the hour part
            return time.Hours;
        }

        private async Task SaveBet()
        {
            if (MessageBox.Show("Are you sure to Save Bet data?", "Confirm Save!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Lấy khung thời gian hiện tại.
                    TimeSpan currentTime = DateTime.Now.TimeOfDay;
                    int timeBlock = GetTimeBlock(currentTime);
                    Console.WriteLine($"The time {currentTime} falls in time block {timeBlock}.");

                    //Lưu thông tin cược
                    BetService betService = new();
                    Bet bet = new () { OnDate = DateTime.Now, PlayerId = CurrenrPlayer.Id, SlotId = timeBlock, Value = (byte)txtBet.Value, IsWin = false };
                    await betService.Save(bet);
                    ReloadBetHistory();
                    MessageBox.Show("Bet Inserted Successfully!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid time format. Please enter time in HH:mm format.");
                }
            }
            else
            {
                // If 'No', do something here.
            }
        }
        /// <summary>
        /// Xử lý quay số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnLottery_Click(object sender, EventArgs e)
        {
            string strValid = CheckValidInput();
            if (!string.IsNullOrEmpty(strValid))
            {
                MessageBox.Show(strValid);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure to Play the Rooster Lottery game?", "Confirm Play!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BetService betService = new();
                    bool value = await betService.Lottery((byte)txtBet.Value);
                    lblResult.Text = value ? "WON" : "LOSE";
                    ReloadBetHistory();
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

        private string CheckValidInput()
        {
            string strRlt = string.Empty;
            if (string.IsNullOrEmpty(txtSearchPhone.Text))
            {
                strRlt = "Please enter Player phone number";
                txtSearchPhone.Focus();
            }
            if (string.IsNullOrEmpty(txtSlot.Text))
            {
                strRlt = "Please enter Slot value";
                txtSlot.Focus();
            }
            if (string.IsNullOrEmpty(txtBet.Text))
            {
                strRlt = "Please enter Bet value";
                txtBet.Focus();
            }
            return strRlt;
        }
        #endregion
    }
}
