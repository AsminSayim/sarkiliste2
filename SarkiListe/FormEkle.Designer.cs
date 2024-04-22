namespace SarkiListe
{
    partial class FormEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSarkiAd = new System.Windows.Forms.TextBox();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.chkFavori = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şarkı Adı";
            // 
            // txtSarkiAd
            // 
            this.txtSarkiAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiAd.Location = new System.Drawing.Point(160, 54);
            this.txtSarkiAd.Name = "txtSarkiAd";
            this.txtSarkiAd.Size = new System.Drawing.Size(274, 26);
            this.txtSarkiAd.TabIndex = 1;
            // 
            // txtSanatci
            // 
            this.txtSanatci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSanatci.Location = new System.Drawing.Point(160, 86);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(274, 26);
            this.txtSanatci.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sanatçı";
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(160, 118);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(274, 26);
            this.txtYil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıl";
            // 
            // txtSure
            // 
            this.txtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.Location = new System.Drawing.Point(160, 184);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(274, 26);
            this.txtSure.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(107, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(119, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tür";
            // 
            // cmbTur
            // 
            this.cmbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Türk Sanat Müziği",
            "Türk Halk Müziği",
            "Arabesk",
            "Rap",
            "Klasik",
            "Jazz",
            "Latin",
            "Hip-Hop"});
            this.cmbTur.Location = new System.Drawing.Point(160, 150);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(274, 28);
            this.cmbTur.TabIndex = 9;
            // 
            // chkFavori
            // 
            this.chkFavori.AutoSize = true;
            this.chkFavori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFavori.Location = new System.Drawing.Point(160, 262);
            this.chkFavori.Name = "chkFavori";
            this.chkFavori.Size = new System.Drawing.Size(77, 24);
            this.chkFavori.TabIndex = 10;
            this.chkFavori.Text = "Favori";
            this.chkFavori.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eklenme Tarihi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(160, 216);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(274, 26);
            this.dtpTarih.TabIndex = 12;
            // 
            // btnCikis
            // 
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(292, 304);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(142, 90);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(160, 304);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 90);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(529, 453);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkFavori);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSarkiAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSarkiAd;
        private System.Windows.Forms.TextBox txtSanatci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.CheckBox chkFavori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
    }
}