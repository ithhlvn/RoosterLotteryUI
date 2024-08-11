using Client.Services;
using RoosterLottery.Models;
using System.Numerics;

namespace RoosterLotteryUI
{
    public partial class FrmPlayerInfo : Form
    {
        #region Fields
        private Player CurrentPlayer = new Player();
        #endregion
        #region Constructors
        public FrmPlayerInfo()
        {
            InitializeComponent();
        }

        public FrmPlayerInfo(Player player) : this()
        {
            SetInfo(player);
        }
        #endregion

        #region Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == (Keys.Control | Keys.S))
                {
                    btnSave.PerformClick();
                    return true;
                }
                if (keyData == (Keys.Control | Keys.B))
                {
                    btnSave.PerformClick();
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

        private void SetInfo(Player? player)
        {
            if (player == null)
            {
                txtFullName.Text = null;
                dtpDoB.CustomFormat = " ";
                dtpDoB.Format = DateTimePickerFormat.Custom;
                txtPhoneNumber.Text = null;
                return;
            }
            txtFullName.Text = player.FullName;
            dtpDoB.Value = (DateTime)player?.DoB;
            txtPhoneNumber.Text = player.Phone;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Save Player data?", "Confirm Save!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PlayerService playerService = new();

                    Player player = new Player { FullName = txtFullName.Text.Trim(), DoB = (DateTime)dtpDoB.Value, Phone = txtPhoneNumber.Text.Trim() };

                    bool isSuccess = await playerService.Save(player);
                    if (isSuccess)
                    {
                        CurrentPlayer = player;
                        MessageBox.Show("Player Inserted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
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

        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Cancel input Player data?", "Confirm Cancel!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetInfo(null);
                CurrentPlayer = new();
            }
        }

        private async void BtnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentPlayer != null && string.IsNullOrEmpty(CurrentPlayer.Phone) == false)
                {
                    PlayerService playerService = new();
                    var player = await playerService.SearchPlayerByPhoneNumber(CurrentPlayer.Phone);
                    //Nếu đã từng đk
                    if (player?.Id > 0)
                    {
                        if (MessageBox.Show("Are you sure to Going to Play Rooster Lottery?", "Confirm Play!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            FrmRoosterLottery frmRoosterLottery = new(CurrentPlayer);
                            using (frmRoosterLottery)
                            {
                                this.Hide();
                                frmRoosterLottery.ShowDialog();
                                frmRoosterLottery.Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Player Not Found");
                    }    
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
