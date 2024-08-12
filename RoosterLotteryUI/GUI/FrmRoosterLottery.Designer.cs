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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoosterLottery));
            label1 = new Label();
            txtFullName = new TextBox();
            gbInputInfo = new GroupBox();
            dtpDoB = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            gbBet = new GroupBox();
            btnSearch = new Button();
            txtSearchPhone = new TextBox();
            label5 = new Label();
            txtBet = new NumericUpDown();
            btnBet = new Button();
            label4 = new Label();
            btnExit = new Button();
            gbInfo = new GroupBox();
            btnAddSlot = new Button();
            txtSlot = new NumericUpDown();
            label6 = new Label();
            lblTimeTick = new Label();
            label7 = new Label();
            timerTick = new System.Windows.Forms.Timer(components);
            gbBetHistory = new GroupBox();
            dgvBet = new DataGridView();
            btnLottery = new Button();
            gbLottery = new GroupBox();
            lblResult = new Label();
            gbInputInfo.SuspendLayout();
            gbBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBet).BeginInit();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSlot).BeginInit();
            gbBetHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBet).BeginInit();
            gbLottery.SuspendLayout();
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
            gbInputInfo.Controls.Add(dtpDoB);
            gbInputInfo.Controls.Add(label3);
            gbInputInfo.Controls.Add(label2);
            gbInputInfo.Controls.Add(label1);
            gbInputInfo.Controls.Add(txtPhoneNumber);
            gbInputInfo.Controls.Add(txtFullName);
            gbInputInfo.Location = new Point(12, 78);
            gbInputInfo.Name = "gbInputInfo";
            gbInputInfo.Size = new Size(346, 119);
            gbInputInfo.TabIndex = 1;
            gbInputInfo.TabStop = false;
            gbInputInfo.Text = "Player info";
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "MM/dd/yyyy";
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.Location = new Point(103, 51);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(237, 23);
            dtpDoB.TabIndex = 1;
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
            // gbBet
            // 
            gbBet.Controls.Add(btnSearch);
            gbBet.Controls.Add(txtSearchPhone);
            gbBet.Controls.Add(label5);
            gbBet.Location = new Point(12, 12);
            gbBet.Name = "gbBet";
            gbBet.Size = new Size(346, 60);
            gbBet.TabIndex = 0;
            gbBet.TabStop = false;
            gbBet.Text = "Search Player";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(275, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearchPhone
            // 
            txtSearchPhone.Location = new Point(103, 22);
            txtSearchPhone.Name = "txtSearchPhone";
            txtSearchPhone.Size = new Size(166, 23);
            txtSearchPhone.TabIndex = 0;
            txtSearchPhone.KeyPress += TextBox1_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Phone number";
            // 
            // txtBet
            // 
            txtBet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBet.ForeColor = Color.Red;
            txtBet.Location = new Point(103, 80);
            txtBet.Name = "txtBet";
            txtBet.Size = new Size(75, 25);
            txtBet.TabIndex = 2;
            // 
            // btnBet
            // 
            btnBet.BackColor = SystemColors.Control;
            btnBet.ForeColor = Color.Red;
            btnBet.Location = new Point(184, 80);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(43, 25);
            btnBet.TabIndex = 3;
            btnBet.Text = "&Bet";
            btnBet.UseVisualStyleBackColor = false;
            btnBet.Click += BtnBet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Bet value";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(651, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(btnAddSlot);
            gbInfo.Controls.Add(txtSlot);
            gbInfo.Controls.Add(txtBet);
            gbInfo.Controls.Add(btnBet);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(lblTimeTick);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(label4);
            gbInfo.Location = new Point(12, 203);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(235, 120);
            gbInfo.TabIndex = 2;
            gbInfo.TabStop = false;
            gbInfo.Text = "Bet info";
            // 
            // btnAddSlot
            // 
            btnAddSlot.Location = new Point(184, 49);
            btnAddSlot.Name = "btnAddSlot";
            btnAddSlot.Size = new Size(43, 23);
            btnAddSlot.TabIndex = 1;
            btnAddSlot.Text = "+";
            btnAddSlot.UseVisualStyleBackColor = true;
            btnAddSlot.Click += BtnAddSlot_Click;
            // 
            // txtSlot
            // 
            txtSlot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSlot.ForeColor = Color.Red;
            txtSlot.Location = new Point(103, 49);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(75, 25);
            txtSlot.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 53);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 0;
            label6.Text = "Slot value";
            // 
            // lblTimeTick
            // 
            lblTimeTick.AutoSize = true;
            lblTimeTick.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeTick.ForeColor = Color.Blue;
            lblTimeTick.Location = new Point(103, 25);
            lblTimeTick.Name = "lblTimeTick";
            lblTimeTick.Size = new Size(80, 17);
            lblTimeTick.TabIndex = 0;
            lblTimeTick.Text = "lblTimeTick";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 0;
            label7.Text = "Timer";
            // 
            // gbBetHistory
            // 
            gbBetHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbBetHistory.Controls.Add(dgvBet);
            gbBetHistory.Location = new Point(364, 12);
            gbBetHistory.Name = "gbBetHistory";
            gbBetHistory.Size = new Size(352, 311);
            gbBetHistory.TabIndex = 4;
            gbBetHistory.TabStop = false;
            gbBetHistory.Text = "Bet History";
            // 
            // dgvBet
            // 
            dgvBet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBet.Dock = DockStyle.Fill;
            dgvBet.Location = new Point(3, 19);
            dgvBet.Name = "dgvBet";
            dgvBet.Size = new Size(346, 289);
            dgvBet.TabIndex = 0;
            // 
            // btnLottery
            // 
            btnLottery.BackColor = Color.FromArgb(255, 192, 192);
            btnLottery.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLottery.ForeColor = Color.Blue;
            btnLottery.Location = new Point(6, 25);
            btnLottery.Name = "btnLottery";
            btnLottery.Size = new Size(93, 43);
            btnLottery.TabIndex = 0;
            btnLottery.Text = "&Lottery";
            btnLottery.UseVisualStyleBackColor = false;
            btnLottery.Click += BtnLottery_Click;
            // 
            // gbLottery
            // 
            gbLottery.Controls.Add(lblResult);
            gbLottery.Controls.Add(btnLottery);
            gbLottery.Location = new Point(253, 203);
            gbLottery.Name = "gbLottery";
            gbLottery.Size = new Size(105, 120);
            gbLottery.TabIndex = 3;
            gbLottery.TabStop = false;
            gbLottery.Text = "Take Lottery";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(24, 84);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(53, 23);
            lblResult.TabIndex = 1;
            lblResult.Text = "WON";
            // 
            // FrmRoosterLottery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 364);
            Controls.Add(gbLottery);
            Controls.Add(gbBetHistory);
            Controls.Add(gbInfo);
            Controls.Add(btnExit);
            Controls.Add(gbBet);
            Controls.Add(gbInputInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmRoosterLottery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooster Lottery";
            gbInputInfo.ResumeLayout(false);
            gbInputInfo.PerformLayout();
            gbBet.ResumeLayout(false);
            gbBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBet).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSlot).EndInit();
            gbBetHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBet).EndInit();
            gbLottery.ResumeLayout(false);
            gbLottery.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private GroupBox gbInputInfo;
        private Label label3;
        private Label label2;
        private TextBox txtPhoneNumber;
        private GroupBox gbBet;
        private Button btnBet;
        private Label label4;
        private TextBox txtSearchPhone;
        private Label label5;
        private DateTimePicker dtpDoB;
        private Button btnExit;
        private NumericUpDown txtBet;
        private Button btnSearch;
        private GroupBox gbInfo;
        private Label lblTimeTick;
        private System.Windows.Forms.Timer timerTick;
        private GroupBox gbBetHistory;
        private NumericUpDown txtSlot;
        private Label label6;
        private Label label7;
        private DataGridView dgvBet;
        private Button btnAddSlot;
        private Button btnLottery;
        private GroupBox gbLottery;
        private Label lblResult;
    }
}
