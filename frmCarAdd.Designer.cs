namespace taxiBolt
{
    partial class frmCarAdd
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
            System.Windows.Forms.Button btnCarCancelModify;
            System.Windows.Forms.Button btnCarApplyModify;
            System.Windows.Forms.Button btnCarAddCancel;
            System.Windows.Forms.Button btnCarAddApply;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarAdd));
            this.pnlCarModify = new System.Windows.Forms.Panel();
            this.txtColorModify = new System.Windows.Forms.TextBox();
            this.txtBrandModify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYearModify = new System.Windows.Forms.TextBox();
            this.txtNumberModify = new System.Windows.Forms.TextBox();
            this.txtModelModify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCarAdd = new System.Windows.Forms.Panel();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            btnCarCancelModify = new System.Windows.Forms.Button();
            btnCarApplyModify = new System.Windows.Forms.Button();
            btnCarAddCancel = new System.Windows.Forms.Button();
            btnCarAddApply = new System.Windows.Forms.Button();
            this.pnlCarModify.SuspendLayout();
            this.pnlCarAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarCancelModify
            // 
            btnCarCancelModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCarCancelModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCarCancelModify.Location = new System.Drawing.Point(48, 290);
            btnCarCancelModify.Name = "btnCarCancelModify";
            btnCarCancelModify.Size = new System.Drawing.Size(153, 37);
            btnCarCancelModify.TabIndex = 52;
            btnCarCancelModify.Text = "İmtina et";
            btnCarCancelModify.UseVisualStyleBackColor = true;
            btnCarCancelModify.Click += new System.EventHandler(this.BtnCarCancelModify_Click);
            // 
            // btnCarApplyModify
            // 
            btnCarApplyModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCarApplyModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCarApplyModify.Location = new System.Drawing.Point(234, 290);
            btnCarApplyModify.Name = "btnCarApplyModify";
            btnCarApplyModify.Size = new System.Drawing.Size(153, 37);
            btnCarApplyModify.TabIndex = 50;
            btnCarApplyModify.Text = "Düzəlişi təstiq et";
            btnCarApplyModify.UseVisualStyleBackColor = true;
            btnCarApplyModify.Click += new System.EventHandler(this.BtnCarApplyModify_Click);
            // 
            // btnCarAddCancel
            // 
            btnCarAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCarAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCarAddCancel.Location = new System.Drawing.Point(51, 296);
            btnCarAddCancel.Name = "btnCarAddCancel";
            btnCarAddCancel.Size = new System.Drawing.Size(153, 37);
            btnCarAddCancel.TabIndex = 52;
            btnCarAddCancel.Text = "İmtina et";
            btnCarAddCancel.UseVisualStyleBackColor = true;
            btnCarAddCancel.Click += new System.EventHandler(this.BtnCarAddCancel_Click);
            // 
            // btnCarAddApply
            // 
            btnCarAddApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCarAddApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCarAddApply.Location = new System.Drawing.Point(237, 296);
            btnCarAddApply.Name = "btnCarAddApply";
            btnCarAddApply.Size = new System.Drawing.Size(153, 37);
            btnCarAddApply.TabIndex = 50;
            btnCarAddApply.Text = "Əlavə et";
            btnCarAddApply.UseVisualStyleBackColor = true;
            btnCarAddApply.Click += new System.EventHandler(this.BtnCarAddApply_Click);
            // 
            // pnlCarModify
            // 
            this.pnlCarModify.Controls.Add(this.txtColorModify);
            this.pnlCarModify.Controls.Add(this.txtBrandModify);
            this.pnlCarModify.Controls.Add(this.label1);
            this.pnlCarModify.Controls.Add(this.txtYearModify);
            this.pnlCarModify.Controls.Add(this.txtNumberModify);
            this.pnlCarModify.Controls.Add(this.txtModelModify);
            this.pnlCarModify.Controls.Add(this.label2);
            this.pnlCarModify.Controls.Add(this.label3);
            this.pnlCarModify.Controls.Add(this.label4);
            this.pnlCarModify.Controls.Add(this.label5);
            this.pnlCarModify.Controls.Add(btnCarCancelModify);
            this.pnlCarModify.Controls.Add(btnCarApplyModify);
            this.pnlCarModify.Location = new System.Drawing.Point(12, 29);
            this.pnlCarModify.Name = "pnlCarModify";
            this.pnlCarModify.Size = new System.Drawing.Size(406, 339);
            this.pnlCarModify.TabIndex = 39;
            // 
            // txtColorModify
            // 
            this.txtColorModify.Location = new System.Drawing.Point(127, 212);
            this.txtColorModify.Name = "txtColorModify";
            this.txtColorModify.Size = new System.Drawing.Size(200, 20);
            this.txtColorModify.TabIndex = 72;
            // 
            // txtBrandModify
            // 
            this.txtBrandModify.Location = new System.Drawing.Point(127, 60);
            this.txtBrandModify.Name = "txtBrandModify";
            this.txtBrandModify.Size = new System.Drawing.Size(200, 20);
            this.txtBrandModify.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Marka";
            // 
            // txtYearModify
            // 
            this.txtYearModify.Location = new System.Drawing.Point(127, 174);
            this.txtYearModify.Name = "txtYearModify";
            this.txtYearModify.Size = new System.Drawing.Size(200, 20);
            this.txtYearModify.TabIndex = 69;
            // 
            // txtNumberModify
            // 
            this.txtNumberModify.Location = new System.Drawing.Point(127, 136);
            this.txtNumberModify.Name = "txtNumberModify";
            this.txtNumberModify.Size = new System.Drawing.Size(200, 20);
            this.txtNumberModify.TabIndex = 68;
            // 
            // txtModelModify
            // 
            this.txtModelModify.Location = new System.Drawing.Point(127, 97);
            this.txtModelModify.Name = "txtModelModify";
            this.txtModelModify.Size = new System.Drawing.Size(200, 20);
            this.txtModelModify.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Rəngi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "İli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nömrə";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Model";
            // 
            // pnlCarAdd
            // 
            this.pnlCarAdd.Controls.Add(this.txtCarColor);
            this.pnlCarAdd.Controls.Add(this.txtBrand);
            this.pnlCarAdd.Controls.Add(this.lblBrand);
            this.pnlCarAdd.Controls.Add(this.txtYear);
            this.pnlCarAdd.Controls.Add(this.txtNumber);
            this.pnlCarAdd.Controls.Add(this.txtModel);
            this.pnlCarAdd.Controls.Add(this.lblColor);
            this.pnlCarAdd.Controls.Add(this.lblYear);
            this.pnlCarAdd.Controls.Add(this.lblNumber);
            this.pnlCarAdd.Controls.Add(this.lblModel);
            this.pnlCarAdd.Controls.Add(btnCarAddCancel);
            this.pnlCarAdd.Controls.Add(btnCarAddApply);
            this.pnlCarAdd.Location = new System.Drawing.Point(6, 11);
            this.pnlCarAdd.Name = "pnlCarAdd";
            this.pnlCarAdd.Size = new System.Drawing.Size(409, 345);
            this.pnlCarAdd.TabIndex = 54;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(128, 208);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(200, 20);
            this.txtCarColor.TabIndex = 62;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(128, 56);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 20);
            this.txtBrand.TabIndex = 61;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(87, 62);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(42, 13);
            this.lblBrand.TabIndex = 60;
            this.lblBrand.Text = "Marka";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(128, 170);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 20);
            this.txtYear.TabIndex = 59;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(128, 132);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 58;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(128, 93);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 20);
            this.txtModel.TabIndex = 57;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(87, 208);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 56;
            this.lblColor.Text = "Rəngi";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(96, 173);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 13);
            this.lblYear.TabIndex = 55;
            this.lblYear.Text = "İli";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(80, 135);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(43, 13);
            this.lblNumber.TabIndex = 54;
            this.lblNumber.Text = "Nömrə";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(87, 99);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 13);
            this.lblModel.TabIndex = 53;
            this.lblModel.Text = "Model";
            // 
            // frmCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 375);
            this.Controls.Add(this.pnlCarAdd);
            this.Controls.Add(this.pnlCarModify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni maşın";
            this.Load += new System.EventHandler(this.FrmCarAdd_Load);
            this.pnlCarModify.ResumeLayout(false);
            this.pnlCarModify.PerformLayout();
            this.pnlCarAdd.ResumeLayout(false);
            this.pnlCarAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCarModify;
        private System.Windows.Forms.Panel pnlCarAdd;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtColorModify;
        private System.Windows.Forms.TextBox txtBrandModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYearModify;
        private System.Windows.Forms.TextBox txtNumberModify;
        private System.Windows.Forms.TextBox txtModelModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}