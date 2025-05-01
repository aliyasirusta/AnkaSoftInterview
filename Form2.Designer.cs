namespace GorevYonetimSistemi
{
    partial class Form2
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
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitSifreTekrar = new System.Windows.Forms.TextBox();
            this.cmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnGirisSayfasinaDon = new System.Windows.Forms.Button();
            this.lblKayitHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(287, 69);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 19);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(343, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(296, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Tekrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(284, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Tipi";
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(393, 62);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(121, 27);
            this.txtKayitKullaniciAdi.TabIndex = 4;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitSifre.Location = new System.Drawing.Point(393, 90);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.PasswordChar = '*';
            this.txtKayitSifre.Size = new System.Drawing.Size(121, 27);
            this.txtKayitSifre.TabIndex = 5;
            // 
            // txtKayitSifreTekrar
            // 
            this.txtKayitSifreTekrar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitSifreTekrar.Location = new System.Drawing.Point(393, 124);
            this.txtKayitSifreTekrar.Name = "txtKayitSifreTekrar";
            this.txtKayitSifreTekrar.PasswordChar = '*';
            this.txtKayitSifreTekrar.Size = new System.Drawing.Size(121, 27);
            this.txtKayitSifreTekrar.TabIndex = 6;
            // 
            // cmbKullaniciTipi
            // 
            this.cmbKullaniciTipi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullaniciTipi.FormattingEnabled = true;
            this.cmbKullaniciTipi.Items.AddRange(new object[] {
            "Standart",
            "Admin"});
            this.cmbKullaniciTipi.Location = new System.Drawing.Point(393, 155);
            this.cmbKullaniciTipi.Name = "cmbKullaniciTipi";
            this.cmbKullaniciTipi.Size = new System.Drawing.Size(121, 27);
            this.cmbKullaniciTipi.TabIndex = 7;
            this.cmbKullaniciTipi.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciTipi_SelectedIndexChanged);
            // 
            // btnKaydol
            // 
            this.btnKaydol.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.Location = new System.Drawing.Point(393, 204);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(121, 53);
            this.btnKaydol.TabIndex = 8;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnGirisSayfasinaDon
            // 
            this.btnGirisSayfasinaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisSayfasinaDon.Location = new System.Drawing.Point(666, 12);
            this.btnGirisSayfasinaDon.Name = "btnGirisSayfasinaDon";
            this.btnGirisSayfasinaDon.Size = new System.Drawing.Size(122, 83);
            this.btnGirisSayfasinaDon.TabIndex = 9;
            this.btnGirisSayfasinaDon.Text = "Giriş Sayfasına Dön";
            this.btnGirisSayfasinaDon.UseVisualStyleBackColor = true;
            this.btnGirisSayfasinaDon.Click += new System.EventHandler(this.btnGirisSayfasinaDon_Click);
            // 
            // lblKayitHata
            // 
            this.lblKayitHata.AutoSize = true;
            this.lblKayitHata.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitHata.ForeColor = System.Drawing.Color.Red;
            this.lblKayitHata.Location = new System.Drawing.Point(268, 278);
            this.lblKayitHata.Name = "lblKayitHata";
            this.lblKayitHata.Size = new System.Drawing.Size(51, 19);
            this.lblKayitHata.TabIndex = 10;
            this.lblKayitHata.Text = "label1";
            this.lblKayitHata.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKayitHata);
            this.Controls.Add(this.btnGirisSayfasinaDon);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.cmbKullaniciTipi);
            this.Controls.Add(this.txtKayitSifreTekrar);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.txtKayitKullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitSifreTekrar;
        private System.Windows.Forms.ComboBox cmbKullaniciTipi;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnGirisSayfasinaDon;
        private System.Windows.Forms.Label lblKayitHata;
    }
}