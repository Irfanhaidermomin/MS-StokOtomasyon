namespace StockDevelopment.WinForm.UI
{
    partial class GirişForm
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
            this.chckBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chckBeniHatirla
            // 
            this.chckBeniHatirla.AutoSize = true;
            this.chckBeniHatirla.Location = new System.Drawing.Point(96, 180);
            this.chckBeniHatirla.Margin = new System.Windows.Forms.Padding(2);
            this.chckBeniHatirla.Name = "chckBeniHatirla";
            this.chckBeniHatirla.Size = new System.Drawing.Size(86, 17);
            this.chckBeniHatirla.TabIndex = 4;
            this.chckBeniHatirla.Text = "Beni Hatırla !";
            this.chckBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.Red;
            this.btnÇıkış.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.ForeColor = System.Drawing.Color.White;
            this.btnÇıkış.Location = new System.Drawing.Point(308, 3);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(27, 27);
            this.btnÇıkış.TabIndex = 6;
            this.btnÇıkış.Text = "X";
            this.btnÇıkış.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnÇıkış.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Blue;
            this.btnTemizle.Location = new System.Drawing.Point(182, 138);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(110, 27);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSifre.Location = new System.Drawing.Point(121, 96);
            this.txtSifre.MaxLength = 18;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(147, 20);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(122, 59);
            this.txtKullaniciAdi.MaxLength = 18;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(147, 20);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // SifremiUnuttum
            // 
            this.SifremiUnuttum.AutoSize = true;
            this.SifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifremiUnuttum.Location = new System.Drawing.Point(235, 180);
            this.SifremiUnuttum.Name = "SifremiUnuttum";
            this.SifremiUnuttum.Size = new System.Drawing.Size(102, 15);
            this.SifremiUnuttum.TabIndex = 5;
            this.SifremiUnuttum.TabStop = true;
            this.SifremiUnuttum.Text = "Şifremi Unuttum !";
            this.SifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SifremiUnuttum_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiris.Location = new System.Drawing.Point(66, 138);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(110, 27);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GirişForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btnÇıkış;
            this.ClientSize = new System.Drawing.Size(338, 206);
            this.Controls.Add(this.chckBeniHatirla);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.SifremiUnuttum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GirişForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.GirişForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chckBeniHatirla;
        public System.Windows.Forms.Button btnÇıkış;
        public System.Windows.Forms.Button btnTemizle;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.LinkLabel SifremiUnuttum;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnGiris;
        public System.Windows.Forms.Label label1;

    }
}