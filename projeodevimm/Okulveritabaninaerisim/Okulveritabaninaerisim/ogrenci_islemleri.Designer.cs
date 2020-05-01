namespace Okulveritabaninaerisim
{
    partial class ogrenci_islemleri
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
            this.id = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.ogrenciliste = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.araa = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.TextBox();
            this.on = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.snf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kadi1 = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(124, 20);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(114, 20);
            this.id.TabIndex = 0;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(124, 95);
            this.Soyad.Multiline = true;
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(114, 20);
            this.Soyad.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(124, 56);
            this.Ad.Multiline = true;
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(114, 20);
            this.Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(550, 294);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 5;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // ogrenciliste
            // 
            this.ogrenciliste.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogrenciliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciliste.Location = new System.Drawing.Point(256, 95);
            this.ogrenciliste.Name = "ogrenciliste";
            this.ogrenciliste.Size = new System.Drawing.Size(537, 183);
            this.ogrenciliste.TabIndex = 6;
            this.ogrenciliste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciliste_CellClick);
            this.ogrenciliste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciliste_CellContentClick);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(456, 294);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 7;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(363, 294);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(75, 23);
            this.güncelle.TabIndex = 8;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // araa
            // 
            this.araa.Location = new System.Drawing.Point(550, 57);
            this.araa.Name = "araa";
            this.araa.Size = new System.Drawing.Size(75, 23);
            this.araa.TabIndex = 9;
            this.araa.Text = "Ara";
            this.araa.UseVisualStyleBackColor = true;
            this.araa.Click += new System.EventHandler(this.araa_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(395, 59);
            this.ara.Multiline = true;
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(112, 20);
            this.ara.TabIndex = 10;
            // 
            // on
            // 
            this.on.Location = new System.Drawing.Point(124, 137);
            this.on.Multiline = true;
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(114, 20);
            this.on.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(2, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Okul Numarası:";
            // 
            // snf
            // 
            this.snf.FormattingEnabled = true;
            this.snf.Items.AddRange(new object[] {
            "9-A",
            "9-B",
            "9-C",
            "10-A",
            "10-B",
            "10-C",
            "11-A",
            "11-B",
            "11-C",
            "12-A",
            "12-B",
            "12-C"});
            this.snf.Location = new System.Drawing.Point(124, 257);
            this.snf.Name = "snf";
            this.snf.Size = new System.Drawing.Size(121, 21);
            this.snf.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(70, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sınıf:";
            // 
            // kadi1
            // 
            this.kadi1.Location = new System.Drawing.Point(124, 178);
            this.kadi1.Multiline = true;
            this.kadi1.Name = "kadi1";
            this.kadi1.Size = new System.Drawing.Size(114, 20);
            this.kadi1.TabIndex = 15;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(122, 219);
            this.sifretxt.Multiline = true;
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(114, 20);
            this.sifretxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(70, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Şifre:";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(122, 297);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(7, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Okulveritabaninaerisim.Properties.Resources.samuel_zeller_379406_unsplash_1024x683;
            this.pictureBox1.Image = global::Okulveritabaninaerisim.Properties.Resources.power_button_512;
            this.pictureBox1.Location = new System.Drawing.Point(768, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(687, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Minimalize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(606, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ogrenci_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Okulveritabaninaerisim.Properties.Resources.samuel_zeller_379406_unsplash_1024x683;
            this.ClientSize = new System.Drawing.Size(831, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kadi1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.snf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.on);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.araa);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ogrenciliste);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrenci_islemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenci_islemleri";
            this.Load += new System.EventHandler(this.ogrenci_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView ogrenciliste;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button araa;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.TextBox on;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox snf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kadi1;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}