namespace GorevYonetimSistemi
{
    partial class AdminPaneliForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneliForm));
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameYeniGorev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKullaniciAta = new System.Windows.Forms.ComboBox();
            this.btnGorevAta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGorevIdGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYeniDurumAdmin = new System.Windows.Forms.ComboBox();
            this.btnGorevDurumGuncelleAdmin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGorevSil = new System.Windows.Forms.Button();
            this.btnGorevleriListele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 272);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(422, 223);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellContentClick);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DimGray;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(817, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(183, 36);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Giriş Ekranına Dön";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgvGorevler
            // 
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Location = new System.Drawing.Point(440, 272);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.RowHeadersWidth = 51;
            this.dgvGorevler.RowTemplate.Height = 24;
            this.dgvGorevler.Size = new System.Drawing.Size(560, 223);
            this.dgvGorevler.TabIndex = 3;
            this.dgvGorevler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGorevler_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Görev";
            // 
            // txtNameYeniGorev
            // 
            this.txtNameYeniGorev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameYeniGorev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameYeniGorev.Location = new System.Drawing.Point(217, 150);
            this.txtNameYeniGorev.Name = "txtNameYeniGorev";
            this.txtNameYeniGorev.Size = new System.Drawing.Size(152, 27);
            this.txtNameYeniGorev.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Görev Atanacak Kişi\r\n\r\n";
            // 
            // cmbKullaniciAta
            // 
            this.cmbKullaniciAta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullaniciAta.FormattingEnabled = true;
            this.cmbKullaniciAta.Location = new System.Drawing.Point(217, 180);
            this.cmbKullaniciAta.Name = "cmbKullaniciAta";
            this.cmbKullaniciAta.Size = new System.Drawing.Size(152, 27);
            this.cmbKullaniciAta.TabIndex = 7;
            // 
            // btnGorevAta
            // 
            this.btnGorevAta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevAta.Location = new System.Drawing.Point(216, 213);
            this.btnGorevAta.Name = "btnGorevAta";
            this.btnGorevAta.Size = new System.Drawing.Size(152, 50);
            this.btnGorevAta.TabIndex = 8;
            this.btnGorevAta.Text = "Görev Ata";
            this.btnGorevAta.UseVisualStyleBackColor = true;
            this.btnGorevAta.Click += new System.EventHandler(this.btnGorevAta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(543, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Görev Durumu Güncelleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(543, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Güncellenmek İstenen Görev ID";
            // 
            // txtGorevIdGuncelle
            // 
            this.txtGorevIdGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevIdGuncelle.Location = new System.Drawing.Point(817, 150);
            this.txtGorevIdGuncelle.Name = "txtGorevIdGuncelle";
            this.txtGorevIdGuncelle.Size = new System.Drawing.Size(145, 27);
            this.txtGorevIdGuncelle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(631, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Güncellenen Durum";
            // 
            // cmbYeniDurumAdmin
            // 
            this.cmbYeniDurumAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYeniDurumAdmin.FormattingEnabled = true;
            this.cmbYeniDurumAdmin.Location = new System.Drawing.Point(816, 183);
            this.cmbYeniDurumAdmin.Name = "cmbYeniDurumAdmin";
            this.cmbYeniDurumAdmin.Size = new System.Drawing.Size(145, 27);
            this.cmbYeniDurumAdmin.TabIndex = 14;
            // 
            // btnGorevDurumGuncelleAdmin
            // 
            this.btnGorevDurumGuncelleAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevDurumGuncelleAdmin.Location = new System.Drawing.Point(817, 216);
            this.btnGorevDurumGuncelleAdmin.Name = "btnGorevDurumGuncelleAdmin";
            this.btnGorevDurumGuncelleAdmin.Size = new System.Drawing.Size(144, 34);
            this.btnGorevDurumGuncelleAdmin.TabIndex = 15;
            this.btnGorevDurumGuncelleAdmin.Text = "Güncelle";
            this.btnGorevDurumGuncelleAdmin.UseVisualStyleBackColor = true;
            this.btnGorevDurumGuncelleAdmin.Click += new System.EventHandler(this.btnGorevDurumGuncelleAdmin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "YÖNETİCİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yeni Görev Atama";
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevSil.Location = new System.Drawing.Point(630, 501);
            this.btnGorevSil.Name = "btnGorevSil";
            this.btnGorevSil.Size = new System.Drawing.Size(155, 40);
            this.btnGorevSil.TabIndex = 18;
            this.btnGorevSil.Text = "Görev Sil";
            this.btnGorevSil.UseVisualStyleBackColor = true;
            this.btnGorevSil.Click += new System.EventHandler(this.btnGorevSil_Click);
            // 
            // btnGorevleriListele
            // 
            this.btnGorevleriListele.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevleriListele.Location = new System.Drawing.Point(791, 501);
            this.btnGorevleriListele.Name = "btnGorevleriListele";
            this.btnGorevleriListele.Size = new System.Drawing.Size(209, 40);
            this.btnGorevleriListele.TabIndex = 19;
            this.btnGorevleriListele.Text = "Tüm Görevleri Listele";
            this.btnGorevleriListele.UseVisualStyleBackColor = true;
            this.btnGorevleriListele.Click += new System.EventHandler(this.btnGorevleriListele_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kullanıcılar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(440, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tüm Görevler";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSil.Location = new System.Drawing.Point(12, 501);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(112, 40);
            this.btnKullaniciSil.TabIndex = 22;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // AdminPaneliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1012, 553);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGorevleriListele);
            this.Controls.Add(this.btnGorevSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGorevDurumGuncelleAdmin);
            this.Controls.Add(this.cmbYeniDurumAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGorevIdGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGorevAta);
            this.Controls.Add(this.cmbKullaniciAta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameYeniGorev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGorevler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "AdminPaneliForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaneliForm";
            this.Load += new System.EventHandler(this.AdminPaneliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameYeniGorev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKullaniciAta;
        private System.Windows.Forms.Button btnGorevAta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGorevIdGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYeniDurumAdmin;
        private System.Windows.Forms.Button btnGorevDurumGuncelleAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGorevSil;
        private System.Windows.Forms.Button btnGorevleriListele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKullaniciSil;
    }
}