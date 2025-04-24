namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblSınav1 = new Label();
            LblSınav2 = new Label();
            LblSınav3 = new Label();
            LblAdSoyad = new Label();
            LblNumara = new Label();
            label11 = new Label();
            LblOrtalama = new Label();
            label13 = new Label();
            LblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 1;
            label2.Text = "Numara:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 2;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 179);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 213);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 4;
            label5.Text = "Sınav 3:";
            // 
            // LblSınav1
            // 
            LblSınav1.AutoSize = true;
            LblSınav1.Location = new Point(132, 142);
            LblSınav1.Name = "LblSınav1";
            LblSınav1.Size = new Size(28, 18);
            LblSınav1.TabIndex = 5;
            LblSınav1.Text = "00";
            LblSınav1.Click += label6_Click;
            // 
            // LblSınav2
            // 
            LblSınav2.AutoSize = true;
            LblSınav2.Location = new Point(132, 179);
            LblSınav2.Name = "LblSınav2";
            LblSınav2.Size = new Size(28, 18);
            LblSınav2.TabIndex = 6;
            LblSınav2.Text = "00";
            // 
            // LblSınav3
            // 
            LblSınav3.AutoSize = true;
            LblSınav3.Location = new Point(132, 213);
            LblSınav3.Name = "LblSınav3";
            LblSınav3.Size = new Size(28, 18);
            LblSınav3.TabIndex = 7;
            LblSınav3.Text = "00";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(132, 29);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(37, 18);
            LblAdSoyad.TabIndex = 8;
            LblAdSoyad.Text = "Null";
            LblAdSoyad.Click += label9_Click;
            // 
            // LblNumara
            // 
            LblNumara.AutoSize = true;
            LblNumara.Location = new Point(129, 62);
            LblNumara.Name = "LblNumara";
            LblNumara.Size = new Size(48, 18);
            LblNumara.TabIndex = 9;
            LblNumara.Text = "0000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 276);
            label11.Name = "label11";
            label11.Size = new Size(80, 18);
            label11.TabIndex = 10;
            label11.Text = "Ortalama:";
            // 
            // LblOrtalama
            // 
            LblOrtalama.AutoSize = true;
            LblOrtalama.Location = new Point(132, 276);
            LblOrtalama.Name = "LblOrtalama";
            LblOrtalama.Size = new Size(28, 18);
            LblOrtalama.TabIndex = 11;
            LblOrtalama.Text = "00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 381);
            label13.Name = "label13";
            label13.Size = new Size(63, 18);
            label13.TabIndex = 12;
            label13.Text = "Durum:";
            // 
            // LblDurum
            // 
            LblDurum.AutoSize = true;
            LblDurum.Location = new Point(132, 381);
            LblDurum.Name = "LblDurum";
            LblDurum.Size = new Size(37, 18);
            LblDurum.TabIndex = 13;
            LblDurum.Text = "Null";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1029, 540);
            Controls.Add(LblDurum);
            Controls.Add(label13);
            Controls.Add(LblOrtalama);
            Controls.Add(label11);
            Controls.Add(LblNumara);
            Controls.Add(LblAdSoyad);
            Controls.Add(LblSınav3);
            Controls.Add(LblSınav2);
            Controls.Add(LblSınav1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblSınav1;
        private Label LblSınav2;
        private Label LblSınav3;
        private Label LblAdSoyad;
        private Label LblNumara;
        private Label label11;
        private Label LblOrtalama;
        private Label label13;
        private Label LblDurum;
    }
}