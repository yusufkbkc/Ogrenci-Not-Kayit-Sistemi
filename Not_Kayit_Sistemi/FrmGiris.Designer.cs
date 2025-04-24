namespace Not_Kayit_Sistemi
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button2 = new Button();
            txtSifre = new TextBox();
            txtOgretmenSifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 294);
            label1.Name = "label1";
            label1.Size = new Size(130, 18);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Numara:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(230, 294);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 26);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
           // maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(165, 422);
            button1.Name = "button1";
            button1.Size = new Size(130, 32);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 346);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.education_3976625;
            pictureBox1.Location = new Point(97, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.teacher_16584868;
            pictureBox2.Location = new Point(499, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 302);
            label4.Name = "label4";
            label4.Size = new Size(122, 18);
            label4.TabIndex = 7;
            label4.Text = "Öğretmen Şifre:";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(560, 422);
            button2.Name = "button2";
            button2.Size = new Size(130, 32);
            button2.TabIndex = 11;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(230, 346);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 26);
            txtSifre.TabIndex = 12;
            // 
            // txtOgretmenSifre
            // 
            txtOgretmenSifre.Location = new Point(560, 346);
            txtOgretmenSifre.Name = "txtOgretmenSifre";
            txtOgretmenSifre.Size = new Size(100, 26);
            txtOgretmenSifre.TabIndex = 13;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(841, 624);
            Controls.Add(txtOgretmenSifre);
            Controls.Add(txtSifre);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "FrmGiris";
            Text = "Öğrenci Not Kayıt Sistemi";
           // Load += FrmGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button2;
        private TextBox txtSifre;
        private TextBox txtOgretmenSifre;
    }
}
