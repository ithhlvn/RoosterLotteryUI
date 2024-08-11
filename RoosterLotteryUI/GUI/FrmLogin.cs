using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Services;
using RoosterLottery.Models;

namespace RoosterLotteryUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == (Keys.Alt | Keys.L) || keyData == Keys.Enter)
                {
                    btnLogin.PerformClick();
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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()) == false)
                {
                    PlayerService playerService = new();
                    var player = await playerService.SearchPlayerByPhoneNumber(txtPhoneNumber.Text.Trim());
                    //Nếu đã từng đk
                    if (player?.Id > 0)
                    {
                        FrmRoosterLottery frmRoosterLottery = new(player);
                        using (frmRoosterLottery)
                        {
                            this.Hide();
                            frmRoosterLottery.ShowDialog();
                            frmRoosterLottery.Dispose();
                        }
                    }
                    else
                    {
                        FrmPlayerInfo frmPlayerInfo = new();
                        using (frmPlayerInfo)
                        {
                            this.Hide();
                            frmPlayerInfo.ShowDialog();
                            frmPlayerInfo.Dispose();
                        }
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
    }
}
