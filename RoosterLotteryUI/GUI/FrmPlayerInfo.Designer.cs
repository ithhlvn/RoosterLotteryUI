namespace RoosterLotteryUI
{
    partial class FrmPlayerInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayerInfo));
            label1 = new Label();
            txtFullName = new TextBox();
            gbInputInfo = new GroupBox();
            btnCancel = new Button();
            dtpDoB = new DateTimePicker();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            btnExit = new Button();
            btnPlay = new Button();
            gbInputInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Player Fullname";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(103, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(237, 23);
            txtFullName.TabIndex = 0;
            // 
            // gbInputInfo
            // 
            gbInputInfo.Controls.Add(btnPlay);
            gbInputInfo.Controls.Add(btnCancel);
            gbInputInfo.Controls.Add(dtpDoB);
            gbInputInfo.Controls.Add(btnSave);
            gbInputInfo.Controls.Add(label3);
            gbInputInfo.Controls.Add(label2);
            gbInputInfo.Controls.Add(label1);
            gbInputInfo.Controls.Add(txtPhoneNumber);
            gbInputInfo.Controls.Add(txtFullName);
            gbInputInfo.Location = new Point(12, 12);
            gbInputInfo.Name = "gbInputInfo";
            gbInputInfo.Size = new Size(346, 144);
            gbInputInfo.TabIndex = 0;
            gbInputInfo.TabStop = false;
            gbInputInfo.Text = "Player info";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(275, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "MM/dd/yyyy";
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.Location = new Point(103, 51);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(237, 23);
            dtpDoB.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(133, 115);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 0;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Date of birth";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(103, 80);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(237, 23);
            txtPhoneNumber.TabIndex = 2;
            txtPhoneNumber.KeyPress += TxtPhoneNumber_KeyPress;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(293, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(204, 115);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(65, 23);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // FrmPlayerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 210);
            Controls.Add(btnExit);
            Controls.Add(gbInputInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPlayerInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Info";
            gbInputInfo.ResumeLayout(false);
            gbInputInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private GroupBox gbInputInfo;
        private Label label3;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private DateTimePicker dtpDoB;
        private Button btnExit;
        private Button btnCancel;
        private Button btnPlay;
    }
}
