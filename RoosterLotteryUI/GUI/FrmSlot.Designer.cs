namespace RoosterLotteryUI
{
    partial class FrmSlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mtbFrTime = new MaskedTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            mtbToTime = new MaskedTextBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mtbFrTime
            // 
            mtbFrTime.Location = new Point(68, 22);
            mtbFrTime.Mask = "HH:mm";
            mtbFrTime.Name = "mtbFrTime";
            mtbFrTime.Size = new Size(97, 23);
            mtbFrTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "FrTime";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(mtbToTime);
            groupBox1.Controls.Add(mtbFrTime);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Slot info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 25);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "ToTime";
            // 
            // mtbToTime
            // 
            mtbToTime.Location = new Point(243, 22);
            mtbToTime.Mask = "HH:mm";
            mtbToTime.Name = "mtbToTime";
            mtbToTime.Size = new Size(97, 23);
            mtbToTime.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(283, 83);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // FrmSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 118);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "FrmSlot";
            Text = "Add Slot";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox mtbFrTime;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private MaskedTextBox mtbToTime;
        private Button btnSave;
    }
}