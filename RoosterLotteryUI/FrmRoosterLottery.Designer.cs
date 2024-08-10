namespace RoosterLotteryUI
{
    partial class FrmRoosterLottery
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
            label1 = new Label();
            txtFullName = new TextBox();
            gbInputInfo = new GroupBox();
            dtpDoB = new DateTimePicker();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            gbBet = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            btnSearch = new Button();
            btnBet = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnExit = new Button();
            gbInputInfo.SuspendLayout();
            gbBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(80, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(286, 23);
            txtFullName.TabIndex = 0;
            // 
            // gbInputInfo
            // 
            gbInputInfo.Controls.Add(dtpDoB);
            gbInputInfo.Controls.Add(btnSave);
            gbInputInfo.Controls.Add(label3);
            gbInputInfo.Controls.Add(label2);
            gbInputInfo.Controls.Add(label1);
            gbInputInfo.Controls.Add(txtPhoneNumber);
            gbInputInfo.Controls.Add(txtFullName);
            gbInputInfo.Location = new Point(12, 12);
            gbInputInfo.Name = "gbInputInfo";
            gbInputInfo.Size = new Size(372, 144);
            gbInputInfo.TabIndex = 0;
            gbInputInfo.TabStop = false;
            gbInputInfo.Text = "Thông tin người dùng";
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "MM/dd/yyyy";
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.Location = new Point(80, 51);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(286, 23);
            dtpDoB.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(291, 109);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(80, 80);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(286, 23);
            txtPhoneNumber.TabIndex = 2;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // gbBet
            // 
            gbBet.Controls.Add(numericUpDown1);
            gbBet.Controls.Add(btnSearch);
            gbBet.Controls.Add(btnBet);
            gbBet.Controls.Add(textBox1);
            gbBet.Controls.Add(label5);
            gbBet.Controls.Add(label4);
            gbBet.Location = new Point(12, 162);
            gbBet.Name = "gbBet";
            gbBet.Size = new Size(372, 116);
            gbBet.TabIndex = 1;
            gbBet.TabStop = false;
            gbBet.Text = "Thông tin đặt cược";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 51);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(147, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(290, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBet
            // 
            btnBet.Location = new Point(291, 80);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(75, 23);
            btnBet.TabIndex = 3;
            btnBet.Text = "&Đặt cược";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Click += btnBet_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 0;
            label5.Text = "Tìm theo số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 0;
            label4.Text = "Giá trị đặt cược";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(309, 292);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmRoosterLottery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 327);
            Controls.Add(btnExit);
            Controls.Add(gbBet);
            Controls.Add(gbInputInfo);
            MaximizeBox = false;
            Name = "FrmRoosterLottery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoosterLottery";
            Load += FrmRoosterLottery_Load;
            gbInputInfo.ResumeLayout(false);
            gbInputInfo.PerformLayout();
            gbBet.ResumeLayout(false);
            gbBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private GroupBox gbBet;
        private Button btnBet;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private DateTimePicker dtpDoB;
        private Button btnExit;
        private NumericUpDown numericUpDown1;
        private Button btnSearch;
    }
}
