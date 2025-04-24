namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            MskNumara = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Txt_Sinav3 = new TextBox();
            Txt_Sinav2 = new TextBox();
            Txt_Sinav1 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            LblOrtalama = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            frmOgretmenDetayBindingSource = new BindingSource(components);
            frmOgretmenDetayBindingSource1 = new BindingSource(components);
            frmOgretmenDetayBindingSource2 = new BindingSource(components);
            frmOgrenciDetayBindingSource = new BindingSource(components);
            frmOgrenciDetayBindingSource1 = new BindingSource(components);
            btnSil = new Button();
            LblGecenSayisi = new Label();
            LblKalanSayisi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frmOgrenciDetayBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frmOgrenciDetayBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(TxtAd);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(98, 119);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(123, 26);
            TxtSoyad.TabIndex = 8;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(98, 85);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(123, 26);
            TxtAd.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(92, 151);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
          //  button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 122);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 5;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 18);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            // 
            // MskNumara
            // 
            MskNumara.Location = new Point(98, 55);
            MskNumara.Mask = "0000";
            MskNumara.Name = "MskNumara";
            MskNumara.Size = new Size(123, 26);
            MskNumara.TabIndex = 1;
            MskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 58);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(Txt_Sinav3);
            groupBox2.Controls.Add(Txt_Sinav2);
            groupBox2.Controls.Add(Txt_Sinav1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(402, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 204);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // Txt_Sinav3
            // 
            Txt_Sinav3.Location = new Point(92, 122);
            Txt_Sinav3.Name = "Txt_Sinav3";
            Txt_Sinav3.Size = new Size(123, 26);
            Txt_Sinav3.TabIndex = 11;
            // 
            // Txt_Sinav2
            // 
            Txt_Sinav2.Location = new Point(92, 90);
            Txt_Sinav2.Name = "Txt_Sinav2";
            Txt_Sinav2.Size = new Size(123, 26);
            Txt_Sinav2.TabIndex = 10;
            // 
            // Txt_Sinav1
            // 
            Txt_Sinav1.Location = new Point(92, 58);
            Txt_Sinav1.Name = "Txt_Sinav1";
            Txt_Sinav1.Size = new Size(123, 26);
            Txt_Sinav1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 125);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 8;
            label6.Text = "Sınav 3:";
            // 
            // button2
            // 
            button2.Location = new Point(92, 154);
            button2.Name = "button2";
            button2.Size = new Size(129, 32);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
           // button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 93);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 5;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 61);
            label5.Name = "label5";
            label5.Size = new Size(64, 18);
            label5.TabIndex = 3;
            label5.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(LblKalanSayisi);
            groupBox3.Controls.Add(LblGecenSayisi);
            groupBox3.Controls.Add(LblOrtalama);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(755, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 204);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ortalama";
            // 
            // LblOrtalama
            // 
            LblOrtalama.AutoSize = true;
            LblOrtalama.Location = new Point(152, 53);
            LblOrtalama.Name = "LblOrtalama";
            LblOrtalama.Size = new Size(28, 18);
            LblOrtalama.TabIndex = 3;
            LblOrtalama.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 130);
            label9.Name = "label9";
            label9.Size = new Size(98, 18);
            label9.TabIndex = 2;
            label9.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 90);
            label8.Name = "label8";
            label8.Size = new Size(102, 18);
            label8.TabIndex = 1;
            label8.Text = "Geçen Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 53);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 0;
            label7.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(23, 310);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1053, 295);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1047, 270);
            dataGridView1.TabIndex = 0;
          //  dataGridView1.CellClick += dataGridView1_CellClick;
          //  dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // frmOgretmenDetayBindingSource
            // 
            frmOgretmenDetayBindingSource.DataSource = typeof(FrmOgretmenDetay);
            // 
            // frmOgretmenDetayBindingSource1
            // 
            frmOgretmenDetayBindingSource1.DataSource = typeof(FrmOgretmenDetay);
            // 
            // frmOgretmenDetayBindingSource2
            // 
            frmOgretmenDetayBindingSource2.DataSource = typeof(FrmOgretmenDetay);
            // 
            // frmOgrenciDetayBindingSource
            // 
            frmOgrenciDetayBindingSource.DataSource = typeof(FrmOgrenciDetay);
            // 
            // frmOgrenciDetayBindingSource1
            // 
            frmOgrenciDetayBindingSource1.DataSource = typeof(FrmOgrenciDetay);
            // 
            // btnSil
            // 
            btnSil.Location = new Point(478, 268);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(162, 36);
            btnSil.TabIndex = 4;
            btnSil.Text = "Öğrenci Sil";
            btnSil.UseVisualStyleBackColor = true;
           // btnSil.Click += btnSil_Click;
            // 
            // LblGecenSayisi
            // 
            LblGecenSayisi.AutoSize = true;
            LblGecenSayisi.Location = new Point(152, 93);
            LblGecenSayisi.Name = "LblGecenSayisi";
            LblGecenSayisi.Size = new Size(28, 18);
            LblGecenSayisi.TabIndex = 4;
            LblGecenSayisi.Text = "00";
            // 
            // LblKalanSayisi
            // 
            LblKalanSayisi.AutoSize = true;
            LblKalanSayisi.Location = new Point(152, 130);
            LblKalanSayisi.Name = "LblKalanSayisi";
            LblKalanSayisi.Size = new Size(28, 18);
            LblKalanSayisi.TabIndex = 5;
            LblKalanSayisi.Text = "00";
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1122, 617);
            Controls.Add(btnSil);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgretmenDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
         //   Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)frmOgretmenDetayBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)frmOgrenciDetayBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frmOgrenciDetayBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private MaskedTextBox MskNumara;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label4;
        private MaskedTextBox maskedTextBox4;
        private Label label5;
        private MaskedTextBox maskedTextBox5;
        private Label label6;
        private MaskedTextBox maskedTextBox6;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label LblOrtalama;
        private GroupBox groupBox4;
        private BindingSource frmOgretmenDetayBindingSource;
        private BindingSource frmOgretmenDetayBindingSource1;
        private DataGridView dataGridView1;
        private BindingSource frmOgretmenDetayBindingSource2;
        private BindingSource frmOgrenciDetayBindingSource;
        private BindingSource frmOgrenciDetayBindingSource1;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private TextBox Txt_Sinav3;
        private TextBox Txt_Sinav2;
        private TextBox Txt_Sinav1;
        private Button btnSil;
        private Label LblKalanSayisi;
        private Label LblGecenSayisi;
    }
}