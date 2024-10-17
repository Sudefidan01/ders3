namespace Ders3
{
    partial class ComboBox_Ornek2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpDegistir = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtDegistir = new System.Windows.Forms.TextBox();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpDegistir.SuspendLayout();
            this.grpEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şehirler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpDegistir
            // 
            this.grpDegistir.BackColor = System.Drawing.Color.Gold;
            this.grpDegistir.Controls.Add(this.txtDegistir);
            this.grpDegistir.Controls.Add(this.btnDegistir);
            this.grpDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDegistir.Location = new System.Drawing.Point(23, 153);
            this.grpDegistir.Name = "grpDegistir";
            this.grpDegistir.Size = new System.Drawing.Size(207, 126);
            this.grpDegistir.TabIndex = 1;
            this.grpDegistir.TabStop = false;
            this.grpDegistir.Text = "Değiştirilecek Şehir";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(28, 77);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(88, 34);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnOku
            // 
            this.btnOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOku.Location = new System.Drawing.Point(298, 153);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(89, 50);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(245, 217);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 62);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(339, 217);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(89, 62);
            this.btnHepsiniSil.TabIndex = 4;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(23, 313);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(429, 113);
            this.lblBilgi.TabIndex = 6;
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDegistir
            // 
            this.txtDegistir.Location = new System.Drawing.Point(28, 29);
            this.txtDegistir.Name = "txtDegistir";
            this.txtDegistir.Size = new System.Drawing.Size(155, 30);
            this.txtDegistir.TabIndex = 2;
            // 
            // grpEkle
            // 
            this.grpEkle.BackColor = System.Drawing.Color.IndianRed;
            this.grpEkle.Controls.Add(this.txtEkle);
            this.grpEkle.Controls.Add(this.btnEkle);
            this.grpEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkle.Location = new System.Drawing.Point(245, 12);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(207, 126);
            this.grpEkle.TabIndex = 3;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "Şehir Ekle";
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(28, 29);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(155, 30);
            this.txtEkle.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(28, 77);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 34);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ComboBox_Ornek2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.grpEkle);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.grpDegistir);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComboBox_Ornek2";
            this.Text = "ComboBox_Ornek2";
            this.Load += new System.EventHandler(this.ComboBox_Ornek2_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpDegistir.ResumeLayout(false);
            this.grpDegistir.PerformLayout();
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpDegistir;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtDegistir;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
    }
}