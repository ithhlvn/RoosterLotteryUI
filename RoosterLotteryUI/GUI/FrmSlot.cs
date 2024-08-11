using Client.Services;
using RoosterLottery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoosterLotteryUI
{
    public partial class FrmSlot : Form
    {
        public FrmSlot()
        {
            InitializeComponent();
        }
        private void InitView()
        {
            mtbFrTime.Mask = "HH:mm";
            mtbToTime.Mask = "HH:mm";
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Save Slot data?", "Confirm Save!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SlotService slotService = new();

                    Slot slot = new() { FrTime = TimeSpan.Parse(mtbFrTime.Text), ToTime = TimeSpan.Parse(mtbToTime.Text) };
                    await slotService.Save(slot);
                    MessageBox.Show("Slot Inserted Successfully!");
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
    }
}
