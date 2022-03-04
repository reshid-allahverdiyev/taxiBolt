namespace taxiBolt
{
    partial class frmDriverAdd
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
            System.Windows.Forms.Button btnDriverAddCancel;
            System.Windows.Forms.Button btnDriverAddApply;
            System.Windows.Forms.Button btnDriverCancelModify;
            System.Windows.Forms.Button btnDriverApplyModify;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDriverAdd));
            this.pnlDriverAdd = new System.Windows.Forms.Panel();
            this.txtDriverNameAdd = new System.Windows.Forms.TextBox();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.dtDriverBirtdayAdd = new System.Windows.Forms.DateTimePicker();
            this.txtDriverFinAdd = new System.Windows.Forms.TextBox();
            this.txtDriverFatherNameAdd = new System.Windows.Forms.TextBox();
            this.txtDriverSurnameAdd = new System.Windows.Forms.TextBox();
            this.lblDriverFin = new System.Windows.Forms.Label();
            this.lblDriverBirtday = new System.Windows.Forms.Label();
            this.lblDriverFatherName = new System.Windows.Forms.Label();
            this.lblDriverSurname = new System.Windows.Forms.Label();
            this.pnlDriverModify = new System.Windows.Forms.Panel();
            this.txtDriverNameModify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDriverBirtdayModify = new System.Windows.Forms.DateTimePicker();
            this.txtDriverFinModify = new System.Windows.Forms.TextBox();
            this.txtDriverFatherNameModify = new System.Windows.Forms.TextBox();
            this.txtDriverSurnameModify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            btnDriverAddCancel = new System.Windows.Forms.Button();
            btnDriverAddApply = new System.Windows.Forms.Button();
            btnDriverCancelModify = new System.Windows.Forms.Button();
            btnDriverApplyModify = new System.Windows.Forms.Button();
            this.pnlDriverAdd.SuspendLayout();
            this.pnlDriverModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDriverAddCancel
            // 
            btnDriverAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnDriverAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDriverAddCancel.Location = new System.Drawing.Point(51, 290);
            btnDriverAddCancel.Name = "btnDriverAddCancel";
            btnDriverAddCancel.Size = new System.Drawing.Size(153, 37);
            btnDriverAddCancel.TabIndex = 52;
            btnDriverAddCancel.Text = "İmtina et";
            btnDriverAddCancel.UseVisualStyleBackColor = true;
            btnDriverAddCancel.Click += new System.EventHandler(this.BtnDriverAddCancel_Click);
            // 
            // btnDriverAddApply
            // 
            btnDriverAddApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnDriverAddApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDriverAddApply.Location = new System.Drawing.Point(237, 290);
            btnDriverAddApply.Name = "btnDriverAddApply";
            btnDriverAddApply.Size = new System.Drawing.Size(153, 37);
            btnDriverAddApply.TabIndex = 50;
            btnDriverAddApply.Text = "Əlavə et";
            btnDriverAddApply.UseVisualStyleBackColor = true;
            btnDriverAddApply.Click += new System.EventHandler(this.BtnDriverAddApply_Click);
            // 
            // btnDriverCancelModify
            // 
            btnDriverCancelModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnDriverCancelModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDriverCancelModify.Location = new System.Drawing.Point(48, 290);
            btnDriverCancelModify.Name = "btnDriverCancelModify";
            btnDriverCancelModify.Size = new System.Drawing.Size(153, 37);
            btnDriverCancelModify.TabIndex = 52;
            btnDriverCancelModify.Text = "İmtina et";
            btnDriverCancelModify.UseVisualStyleBackColor = true;
            btnDriverCancelModify.Click += new System.EventHandler(this.BtnDriverCancelModify_Click);
            // 
            // btnDriverApplyModify
            // 
            btnDriverApplyModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnDriverApplyModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDriverApplyModify.Location = new System.Drawing.Point(234, 290);
            btnDriverApplyModify.Name = "btnDriverApplyModify";
            btnDriverApplyModify.Size = new System.Drawing.Size(153, 37);
            btnDriverApplyModify.TabIndex = 50;
            btnDriverApplyModify.Text = "Düzəlişi təstiq et";
            btnDriverApplyModify.UseVisualStyleBackColor = true;
            btnDriverApplyModify.Click += new System.EventHandler(this.BtnDriverApplyModify_Click);
            // 
            // pnlDriverAdd
            // 
            this.pnlDriverAdd.Controls.Add(this.txtDriverNameAdd);
            this.pnlDriverAdd.Controls.Add(this.lblDriverName);
            this.pnlDriverAdd.Controls.Add(this.dtDriverBirtdayAdd);
            this.pnlDriverAdd.Controls.Add(this.txtDriverFinAdd);
            this.pnlDriverAdd.Controls.Add(this.txtDriverFatherNameAdd);
            this.pnlDriverAdd.Controls.Add(this.txtDriverSurnameAdd);
            this.pnlDriverAdd.Controls.Add(this.lblDriverFin);
            this.pnlDriverAdd.Controls.Add(this.lblDriverBirtday);
            this.pnlDriverAdd.Controls.Add(this.lblDriverFatherName);
            this.pnlDriverAdd.Controls.Add(this.lblDriverSurname);
            this.pnlDriverAdd.Controls.Add(btnDriverAddCancel);
            this.pnlDriverAdd.Controls.Add(btnDriverAddApply);
            this.pnlDriverAdd.Location = new System.Drawing.Point(12, 12);
            this.pnlDriverAdd.Name = "pnlDriverAdd";
            this.pnlDriverAdd.Size = new System.Drawing.Size(409, 339);
            this.pnlDriverAdd.TabIndex = 55;
            // 
            // txtDriverNameAdd
            // 
            this.txtDriverNameAdd.Location = new System.Drawing.Point(114, 52);
            this.txtDriverNameAdd.Name = "txtDriverNameAdd";
            this.txtDriverNameAdd.Size = new System.Drawing.Size(200, 20);
            this.txtDriverNameAdd.TabIndex = 62;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.Location = new System.Drawing.Point(73, 58);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(22, 13);
            this.lblDriverName.TabIndex = 61;
            this.lblDriverName.Text = "Ad";
            // 
            // dtDriverBirtdayAdd
            // 
            this.dtDriverBirtdayAdd.Location = new System.Drawing.Point(114, 163);
            this.dtDriverBirtdayAdd.Name = "dtDriverBirtdayAdd";
            this.dtDriverBirtdayAdd.Size = new System.Drawing.Size(270, 20);
            this.dtDriverBirtdayAdd.TabIndex = 60;
            // 
            // txtDriverFinAdd
            // 
            this.txtDriverFinAdd.Location = new System.Drawing.Point(114, 204);
            this.txtDriverFinAdd.Name = "txtDriverFinAdd";
            this.txtDriverFinAdd.Size = new System.Drawing.Size(200, 20);
            this.txtDriverFinAdd.TabIndex = 59;
            // 
            // txtDriverFatherNameAdd
            // 
            this.txtDriverFatherNameAdd.Location = new System.Drawing.Point(114, 126);
            this.txtDriverFatherNameAdd.Name = "txtDriverFatherNameAdd";
            this.txtDriverFatherNameAdd.Size = new System.Drawing.Size(200, 20);
            this.txtDriverFatherNameAdd.TabIndex = 58;
            // 
            // txtDriverSurnameAdd
            // 
            this.txtDriverSurnameAdd.Location = new System.Drawing.Point(114, 87);
            this.txtDriverSurnameAdd.Name = "txtDriverSurnameAdd";
            this.txtDriverSurnameAdd.Size = new System.Drawing.Size(200, 20);
            this.txtDriverSurnameAdd.TabIndex = 57;
            // 
            // lblDriverFin
            // 
            this.lblDriverFin.AutoSize = true;
            this.lblDriverFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverFin.Location = new System.Drawing.Point(66, 206);
            this.lblDriverFin.Name = "lblDriverFin";
            this.lblDriverFin.Size = new System.Drawing.Size(24, 13);
            this.lblDriverFin.TabIndex = 56;
            this.lblDriverFin.Text = "Fin";
            // 
            // lblDriverBirtday
            // 
            this.lblDriverBirtday.AutoSize = true;
            this.lblDriverBirtday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverBirtday.Location = new System.Drawing.Point(24, 168);
            this.lblDriverBirtday.Name = "lblDriverBirtday";
            this.lblDriverBirtday.Size = new System.Drawing.Size(77, 13);
            this.lblDriverBirtday.TabIndex = 55;
            this.lblDriverBirtday.Text = "Doğum tarixi";
            // 
            // lblDriverFatherName
            // 
            this.lblDriverFatherName.AutoSize = true;
            this.lblDriverFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverFatherName.Location = new System.Drawing.Point(52, 129);
            this.lblDriverFatherName.Name = "lblDriverFatherName";
            this.lblDriverFatherName.Size = new System.Drawing.Size(51, 13);
            this.lblDriverFatherName.TabIndex = 54;
            this.lblDriverFatherName.Text = "Ata adı ";
            // 
            // lblDriverSurname
            // 
            this.lblDriverSurname.AutoSize = true;
            this.lblDriverSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverSurname.Location = new System.Drawing.Point(52, 90);
            this.lblDriverSurname.Name = "lblDriverSurname";
            this.lblDriverSurname.Size = new System.Drawing.Size(42, 13);
            this.lblDriverSurname.TabIndex = 53;
            this.lblDriverSurname.Text = "Soyad";
            // 
            // pnlDriverModify
            // 
            this.pnlDriverModify.Controls.Add(this.txtDriverNameModify);
            this.pnlDriverModify.Controls.Add(this.label1);
            this.pnlDriverModify.Controls.Add(this.dtDriverBirtdayModify);
            this.pnlDriverModify.Controls.Add(this.txtDriverFinModify);
            this.pnlDriverModify.Controls.Add(this.txtDriverFatherNameModify);
            this.pnlDriverModify.Controls.Add(this.txtDriverSurnameModify);
            this.pnlDriverModify.Controls.Add(this.label2);
            this.pnlDriverModify.Controls.Add(this.label3);
            this.pnlDriverModify.Controls.Add(this.label4);
            this.pnlDriverModify.Controls.Add(this.label5);
            this.pnlDriverModify.Controls.Add(btnDriverCancelModify);
            this.pnlDriverModify.Controls.Add(btnDriverApplyModify);
            this.pnlDriverModify.Location = new System.Drawing.Point(12, 12);
            this.pnlDriverModify.Name = "pnlDriverModify";
            this.pnlDriverModify.Size = new System.Drawing.Size(406, 339);
            this.pnlDriverModify.TabIndex = 56;
            // 
            // txtDriverNameModify
            // 
            this.txtDriverNameModify.Location = new System.Drawing.Point(116, 49);
            this.txtDriverNameModify.Name = "txtDriverNameModify";
            this.txtDriverNameModify.Size = new System.Drawing.Size(200, 20);
            this.txtDriverNameModify.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Ad";
            // 
            // dtDriverBirtdayModify
            // 
            this.dtDriverBirtdayModify.Location = new System.Drawing.Point(116, 160);
            this.dtDriverBirtdayModify.Name = "dtDriverBirtdayModify";
            this.dtDriverBirtdayModify.Size = new System.Drawing.Size(270, 20);
            this.dtDriverBirtdayModify.TabIndex = 70;
            // 
            // txtDriverFinModify
            // 
            this.txtDriverFinModify.Location = new System.Drawing.Point(116, 201);
            this.txtDriverFinModify.Name = "txtDriverFinModify";
            this.txtDriverFinModify.Size = new System.Drawing.Size(200, 20);
            this.txtDriverFinModify.TabIndex = 69;
            // 
            // txtDriverFatherNameModify
            // 
            this.txtDriverFatherNameModify.Location = new System.Drawing.Point(116, 123);
            this.txtDriverFatherNameModify.Name = "txtDriverFatherNameModify";
            this.txtDriverFatherNameModify.Size = new System.Drawing.Size(200, 20);
            this.txtDriverFatherNameModify.TabIndex = 68;
            // 
            // txtDriverSurnameModify
            // 
            this.txtDriverSurnameModify.Location = new System.Drawing.Point(116, 84);
            this.txtDriverSurnameModify.Name = "txtDriverSurnameModify";
            this.txtDriverSurnameModify.Size = new System.Drawing.Size(200, 20);
            this.txtDriverSurnameModify.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Doğum tarixi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ata adı ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Soyad";
            // 
            // frmDriverAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 355);
            this.Controls.Add(this.pnlDriverModify);
            this.Controls.Add(this.pnlDriverAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDriverAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni sürücü";
            this.Load += new System.EventHandler(this.FrmDriverAdd_Load);
            this.pnlDriverAdd.ResumeLayout(false);
            this.pnlDriverAdd.PerformLayout();
            this.pnlDriverModify.ResumeLayout(false);
            this.pnlDriverModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDriverAdd;
        private System.Windows.Forms.Panel pnlDriverModify;
        private System.Windows.Forms.TextBox txtDriverNameAdd;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.DateTimePicker dtDriverBirtdayAdd;
        private System.Windows.Forms.TextBox txtDriverFinAdd;
        private System.Windows.Forms.TextBox txtDriverFatherNameAdd;
        private System.Windows.Forms.TextBox txtDriverSurnameAdd;
        private System.Windows.Forms.Label lblDriverFin;
        private System.Windows.Forms.Label lblDriverBirtday;
        private System.Windows.Forms.Label lblDriverFatherName;
        private System.Windows.Forms.Label lblDriverSurname;
        private System.Windows.Forms.TextBox txtDriverNameModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDriverBirtdayModify;
        private System.Windows.Forms.TextBox txtDriverFinModify;
        private System.Windows.Forms.TextBox txtDriverFatherNameModify;
        private System.Windows.Forms.TextBox txtDriverSurnameModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}