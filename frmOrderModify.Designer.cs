namespace taxiBolt
{
    partial class frmOrderModify
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
            System.Windows.Forms.Button btnOrderModifyCancel;
            System.Windows.Forms.Button btnOrderModifyApply;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderModify));
            this.lblLastAmount = new System.Windows.Forms.Label();
            this.txtLastAmount = new System.Windows.Forms.TextBox();
            this.chckPayed = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayedByCash = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCommonAmount = new System.Windows.Forms.TextBox();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCommonCostNote = new System.Windows.Forms.TextBox();
            this.lblSpecialCost = new System.Windows.Forms.Label();
            this.txtSpecialCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSpecialCostNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCommonCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFuelMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDrivingDistance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoltCompensation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayedToBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxQueue = new System.Windows.Forms.ComboBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayedByCard = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            btnOrderModifyCancel = new System.Windows.Forms.Button();
            btnOrderModifyApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderModifyCancel
            // 
            btnOrderModifyCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnOrderModifyCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOrderModifyCancel.Location = new System.Drawing.Point(520, 370);
            btnOrderModifyCancel.Name = "btnOrderModifyCancel";
            btnOrderModifyCancel.Size = new System.Drawing.Size(153, 58);
            btnOrderModifyCancel.TabIndex = 98;
            btnOrderModifyCancel.Text = "İmtina et";
            btnOrderModifyCancel.UseVisualStyleBackColor = true;
            btnOrderModifyCancel.Click += new System.EventHandler(this.BtnOrderModifyCancel_Click);
            // 
            // btnOrderModifyApply
            // 
            btnOrderModifyApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnOrderModifyApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOrderModifyApply.Location = new System.Drawing.Point(706, 370);
            btnOrderModifyApply.Name = "btnOrderModifyApply";
            btnOrderModifyApply.Size = new System.Drawing.Size(153, 58);
            btnOrderModifyApply.TabIndex = 97;
            btnOrderModifyApply.Text = "Düzəliş et";
            btnOrderModifyApply.UseVisualStyleBackColor = true;
            btnOrderModifyApply.Click += new System.EventHandler(this.BtnOrderModifyApply_Click);
            // 
            // lblLastAmount
            // 
            this.lblLastAmount.AutoSize = true;
            this.lblLastAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAmount.Location = new System.Drawing.Point(65, 358);
            this.lblLastAmount.Name = "lblLastAmount";
            this.lblLastAmount.Size = new System.Drawing.Size(91, 16);
            this.lblLastAmount.TabIndex = 136;
            this.lblLastAmount.Text = "Son məbləğ";
            // 
            // txtLastAmount
            // 
            this.txtLastAmount.Location = new System.Drawing.Point(185, 358);
            this.txtLastAmount.Name = "txtLastAmount";
            this.txtLastAmount.ReadOnly = true;
            this.txtLastAmount.Size = new System.Drawing.Size(208, 20);
            this.txtLastAmount.TabIndex = 135;
            // 
            // chckPayed
            // 
            this.chckPayed.AutoSize = true;
            this.chckPayed.Location = new System.Drawing.Point(652, 321);
            this.chckPayed.Name = "chckPayed";
            this.chckPayed.Size = new System.Drawing.Size(15, 14);
            this.chckPayed.TabIndex = 134;
            this.chckPayed.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 133;
            this.label10.Text = "Sifariş ödənilib?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 132;
            this.label3.Text = "Nəğd ödəniş";
            // 
            // txtPayedByCash
            // 
            this.txtPayedByCash.Location = new System.Drawing.Point(185, 320);
            this.txtPayedByCash.Name = "txtPayedByCash";
            this.txtPayedByCash.ReadOnly = true;
            this.txtPayedByCash.Size = new System.Drawing.Size(208, 20);
            this.txtPayedByCash.TabIndex = 131;
            this.txtPayedByCash.TextChanged += new System.EventHandler(this.TxtPayedByCash_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(69, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 16);
            this.label17.TabIndex = 130;
            this.label17.Text = "Ümumi məbləğ";
            // 
            // txtCommonAmount
            // 
            this.txtCommonAmount.Location = new System.Drawing.Point(185, 166);
            this.txtCommonAmount.Name = "txtCommonAmount";
            this.txtCommonAmount.Size = new System.Drawing.Size(208, 20);
            this.txtCommonAmount.TabIndex = 129;
            this.txtCommonAmount.TextChanged += new System.EventHandler(this.TxtCommonAmount_TextChanged_1);
            // 
            // cmbDriver
            // 
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Items.AddRange(new object[] {
            "Gündüz",
            "Gecə"});
            this.cmbDriver.Location = new System.Drawing.Point(185, 92);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(208, 21);
            this.cmbDriver.TabIndex = 128;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(119, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 127;
            this.label16.Text = "Sürücü";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Items.AddRange(new object[] {
            "Gündüz",
            "Gecə"});
            this.cmbCar.Location = new System.Drawing.Point(185, 129);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(208, 21);
            this.cmbCar.TabIndex = 126;
            this.cmbCar.SelectedIndexChanged += new System.EventHandler(this.CmbCar_SelectedIndexChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 125;
            this.label15.Text = "Maşın";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 16);
            this.label14.TabIndex = 124;
            this.label14.Text = "Ümumi xərc haqda qeyd";
            // 
            // txtCommonCostNote
            // 
            this.txtCommonCostNote.Location = new System.Drawing.Point(651, 208);
            this.txtCommonCostNote.Name = "txtCommonCostNote";
            this.txtCommonCostNote.Size = new System.Drawing.Size(208, 20);
            this.txtCommonCostNote.TabIndex = 123;
            // 
            // lblSpecialCost
            // 
            this.lblSpecialCost.AutoSize = true;
            this.lblSpecialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialCost.Location = new System.Drawing.Point(551, 249);
            this.lblSpecialCost.Name = "lblSpecialCost";
            this.lblSpecialCost.Size = new System.Drawing.Size(86, 16);
            this.lblSpecialCost.TabIndex = 122;
            this.lblSpecialCost.Text = "Xüsusi xərc";
            // 
            // txtSpecialCost
            // 
            this.txtSpecialCost.Location = new System.Drawing.Point(651, 246);
            this.txtSpecialCost.Name = "txtSpecialCost";
            this.txtSpecialCost.Size = new System.Drawing.Size(208, 20);
            this.txtSpecialCost.TabIndex = 121;
            this.txtSpecialCost.TextChanged += new System.EventHandler(this.TxtSpecialCost_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(466, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 16);
            this.label12.TabIndex = 120;
            this.label12.Text = "Xüsusi xərc haqda qeyd";
            // 
            // txtSpecialCostNote
            // 
            this.txtSpecialCostNote.Location = new System.Drawing.Point(651, 283);
            this.txtSpecialCostNote.Name = "txtSpecialCostNote";
            this.txtSpecialCostNote.Size = new System.Drawing.Size(208, 20);
            this.txtSpecialCostNote.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(551, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 118;
            this.label11.Text = "Ümumi xərc";
            // 
            // txtCommonCost
            // 
            this.txtCommonCost.Location = new System.Drawing.Point(651, 170);
            this.txtCommonCost.Name = "txtCommonCost";
            this.txtCommonCost.Size = new System.Drawing.Size(208, 20);
            this.txtCommonCost.TabIndex = 117;
            this.txtCommonCost.TextChanged += new System.EventHandler(this.TxtCommonCost_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 116;
            this.label9.Text = "Avans";
            // 
            // txtAvance
            // 
            this.txtAvance.Location = new System.Drawing.Point(651, 131);
            this.txtAvance.Name = "txtAvance";
            this.txtAvance.Size = new System.Drawing.Size(208, 20);
            this.txtAvance.TabIndex = 115;
            this.txtAvance.TextChanged += new System.EventHandler(this.TxtAvance_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 114;
            this.label8.Text = "Yanacaq pulu";
            // 
            // txtFuelMoney
            // 
            this.txtFuelMoney.Location = new System.Drawing.Point(651, 93);
            this.txtFuelMoney.Name = "txtFuelMoney";
            this.txtFuelMoney.Size = new System.Drawing.Size(208, 20);
            this.txtFuelMoney.TabIndex = 113;
            this.txtFuelMoney.TextChanged += new System.EventHandler(this.TxtFuelMoney_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = "Maşının yürüşü";
            // 
            // txtLastDistance
            // 
            this.txtLastDistance.Location = new System.Drawing.Point(652, 24);
            this.txtLastDistance.Name = "txtLastDistance";
            this.txtLastDistance.Size = new System.Drawing.Size(208, 20);
            this.txtLastDistance.TabIndex = 111;
            this.txtLastDistance.TextChanged += new System.EventHandler(this.TxtLastDistance_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Sürülən məsafə";
            // 
            // txtDrivingDistance
            // 
            this.txtDrivingDistance.Location = new System.Drawing.Point(652, 57);
            this.txtDrivingDistance.Name = "txtDrivingDistance";
            this.txtDrivingDistance.ReadOnly = true;
            this.txtDrivingDistance.Size = new System.Drawing.Size(208, 20);
            this.txtDrivingDistance.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 108;
            this.label5.Text = "Bolt kompensasiya";
            // 
            // txtBoltCompensation
            // 
            this.txtBoltCompensation.Location = new System.Drawing.Point(185, 281);
            this.txtBoltCompensation.Name = "txtBoltCompensation";
            this.txtBoltCompensation.Size = new System.Drawing.Size(208, 20);
            this.txtBoltCompensation.TabIndex = 107;
            this.txtBoltCompensation.TextChanged += new System.EventHandler(this.TxtBoltCompensation_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Balansa ödənən";
            // 
            // txtPayedToBalance
            // 
            this.txtPayedToBalance.Location = new System.Drawing.Point(185, 243);
            this.txtPayedToBalance.Name = "txtPayedToBalance";
            this.txtPayedToBalance.Size = new System.Drawing.Size(208, 20);
            this.txtPayedToBalance.TabIndex = 105;
            this.txtPayedToBalance.TextChanged += new System.EventHandler(this.TxtPayedToBalance_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Kartla ödənən";
            // 
            // cmbxQueue
            // 
            this.cmbxQueue.FormattingEnabled = true;
            this.cmbxQueue.Items.AddRange(new object[] {
            "Gündüz",
            "Gecə"});
            this.cmbxQueue.Location = new System.Drawing.Point(185, 57);
            this.cmbxQueue.Name = "cmbxQueue";
            this.cmbxQueue.Size = new System.Drawing.Size(208, 21);
            this.cmbxQueue.TabIndex = 103;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(185, 20);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(208, 20);
            this.dtOrderDate.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tarix";
            // 
            // txtPayedByCard
            // 
            this.txtPayedByCard.Location = new System.Drawing.Point(185, 203);
            this.txtPayedByCard.Name = "txtPayedByCard";
            this.txtPayedByCard.Size = new System.Drawing.Size(208, 20);
            this.txtPayedByCard.TabIndex = 100;
            this.txtPayedByCard.TextChanged += new System.EventHandler(this.TxtPayedByCard_TextChanged_1);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(119, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 16);
            this.lbl1.TabIndex = 99;
            this.lbl1.Text = "Növbə";
            // 
            // frmOrderModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.lblLastAmount);
            this.Controls.Add(this.txtLastAmount);
            this.Controls.Add(this.chckPayed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPayedByCash);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCommonAmount);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCommonCostNote);
            this.Controls.Add(this.lblSpecialCost);
            this.Controls.Add(this.txtSpecialCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSpecialCostNote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCommonCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAvance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFuelMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLastDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDrivingDistance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoltCompensation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPayedToBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxQueue);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayedByCard);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(btnOrderModifyCancel);
            this.Controls.Add(btnOrderModifyApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderModify";
            this.Text = "Düzəliş et";
            this.Load += new System.EventHandler(this.FrmOrderModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastAmount;
        private System.Windows.Forms.TextBox txtLastAmount;
        private System.Windows.Forms.CheckBox chckPayed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayedByCash;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCommonAmount;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCommonCostNote;
        private System.Windows.Forms.Label lblSpecialCost;
        private System.Windows.Forms.TextBox txtSpecialCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSpecialCostNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCommonCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFuelMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDrivingDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoltCompensation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayedToBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxQueue;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayedByCard;
        private System.Windows.Forms.Label lbl1;
    }
}