namespace GorevYonetimSistemi
{
    partial class StandartKullaniciPaneliForm
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
            this.dgvGorevlerim = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGorevIdGuncelleStandart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYeniDurumStandart = new System.Windows.Forms.ComboBox();
            this.btnGorevDurumGuncelleStandart = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciTipi = new System.Windows.Forms.Label();
            this.lblNameTamamlanmamisSayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevlerim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGorevlerim
            // 
            this.dgvGorevlerim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGorevlerim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGorevlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevlerim.Location = new System.Drawing.Point(12, 297);
            this.dgvGorevlerim.Name = "dgvGorevlerim";
            this.dgvGorevlerim.RowHeadersWidth = 51;
            this.dgvGorevlerim.RowTemplate.Height = 24;
            this.dgvGorevlerim.Size = new System.Drawing.Size(958, 253);
            this.dgvGorevlerim.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(865, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(105, 72);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(587, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "GÖREV DURUMU GÜNCELLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(587, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güncelleme Yapılacak Görev ID";
            // 
            // txtGorevIdGuncelleStandart
            // 
            this.txtGorevIdGuncelleStandart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevIdGuncelleStandart.Location = new System.Drawing.Point(833, 174);
            this.txtGorevIdGuncelleStandart.Name = "txtGorevIdGuncelleStandart";
            this.txtGorevIdGuncelleStandart.Size = new System.Drawing.Size(136, 27);
            this.txtGorevIdGuncelleStandart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Güncellenen Durum";
            // 
            // cmbYeniDurumStandart
            // 
            this.cmbYeniDurumStandart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYeniDurumStandart.FormattingEnabled = true;
            this.cmbYeniDurumStandart.Location = new System.Drawing.Point(833, 207);
            this.cmbYeniDurumStandart.Name = "cmbYeniDurumStandart";
            this.cmbYeniDurumStandart.Size = new System.Drawing.Size(136, 27);
            this.cmbYeniDurumStandart.TabIndex = 6;
            // 
            // btnGorevDurumGuncelleStandart
            // 
            this.btnGorevDurumGuncelleStandart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevDurumGuncelleStandart.Location = new System.Drawing.Point(773, 240);
            this.btnGorevDurumGuncelleStandart.Name = "btnGorevDurumGuncelleStandart";
            this.btnGorevDurumGuncelleStandart.Size = new System.Drawing.Size(196, 44);
            this.btnGorevDurumGuncelleStandart.TabIndex = 7;
            this.btnGorevDurumGuncelleStandart.Text = "Güncelle";
            this.btnGorevDurumGuncelleStandart.UseVisualStyleBackColor = true;
            this.btnGorevDurumGuncelleStandart.Click += new System.EventHandler(this.btnGorevDurumGuncelleStandart_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Enabled = false;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(48, 27);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 23);
            this.lblKullaniciAdi.TabIndex = 8;
            // 
            // lblKullaniciTipi
            // 
            this.lblKullaniciTipi.AutoSize = true;
            this.lblKullaniciTipi.Enabled = false;
            this.lblKullaniciTipi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciTipi.Location = new System.Drawing.Point(51, 61);
            this.lblKullaniciTipi.Name = "lblKullaniciTipi";
            this.lblKullaniciTipi.Size = new System.Drawing.Size(0, 23);
            this.lblKullaniciTipi.TabIndex = 9;
            // 
            // lblNameTamamlanmamisSayi
            // 
            this.lblNameTamamlanmamisSayi.AutoSize = true;
            this.lblNameTamamlanmamisSayi.Enabled = false;
            this.lblNameTamamlanmamisSayi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameTamamlanmamisSayi.Location = new System.Drawing.Point(287, 104);
            this.lblNameTamamlanmamisSayi.Name = "lblNameTamamlanmamisSayi";
            this.lblNameTamamlanmamisSayi.Size = new System.Drawing.Size(0, 19);
            this.lblNameTamamlanmamisSayi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tamamlanmamış Görev Sayısı";
            // 
            // StandartKullaniciPaneliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNameTamamlanmamisSayi);
            this.Controls.Add(this.lblKullaniciTipi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnGorevDurumGuncelleStandart);
            this.Controls.Add(this.cmbYeniDurumStandart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGorevIdGuncelleStandart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvGorevlerim);
            this.Name = "StandartKullaniciPaneliForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandartKullaniciPaneliForm";
            this.Load += new System.EventHandler(this.StandartKullaniciPaneliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevlerim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGorevlerim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGorevIdGuncelleStandart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYeniDurumStandart;
        private System.Windows.Forms.Button btnGorevDurumGuncelleStandart;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciTipi;
        private System.Windows.Forms.Label lblNameTamamlanmamisSayi;
        private System.Windows.Forms.Label label4;
    }
}