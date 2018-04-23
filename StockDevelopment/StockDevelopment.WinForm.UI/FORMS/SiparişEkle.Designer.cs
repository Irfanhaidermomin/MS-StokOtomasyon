namespace StockDevelopment.WinForm.UI.FORMS
{
    partial class SiparişEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSiparisEt = new System.Windows.Forms.Button();
            this.btnListeyeEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   SİPARİŞ BİLGİSİ   ";
            // 
            // txtMiktar
            // 
            this.txtMiktar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(125, 55);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(188, 19);
            this.txtMiktar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 145;
            this.label9.Text = "Ürün Adı :";
            // 
            // txtAdi
            // 
            this.txtAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(125, 24);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(188, 19);
            this.txtAdi.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 146;
            this.label10.Text = "Ürün Miktarı :";
            // 
            // btnSiparisEt
            // 
            this.btnSiparisEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEt.ForeColor = System.Drawing.Color.Green;
            this.btnSiparisEt.Location = new System.Drawing.Point(13, 104);
            this.btnSiparisEt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisEt.Name = "btnSiparisEt";
            this.btnSiparisEt.Size = new System.Drawing.Size(147, 36);
            this.btnSiparisEt.TabIndex = 1;
            this.btnSiparisEt.Text = "Direkt  Sipariş  Et";
            this.btnSiparisEt.UseVisualStyleBackColor = true;
            this.btnSiparisEt.Click += new System.EventHandler(this.btnSiparisEt_Click);
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeyeEkle.ForeColor = System.Drawing.Color.Red;
            this.btnListeyeEkle.Location = new System.Drawing.Point(165, 104);
            this.btnListeyeEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(175, 36);
            this.btnListeyeEkle.TabIndex = 2;
            this.btnListeyeEkle.Text = "Sipariş  Listesine  Ekle";
            this.btnListeyeEkle.UseVisualStyleBackColor = true;
            this.btnListeyeEkle.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // SiparişEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(370, 152);
            this.Controls.Add(this.btnListeyeEkle);
            this.Controls.Add(this.btnSiparisEt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SiparişEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<<   Sipariş Ekle   >>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSiparisEt;
        private System.Windows.Forms.Button btnListeyeEkle;
    }
}