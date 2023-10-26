namespace LoginEkrani
{
    partial class Form1
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
            label2 = new Label();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            buttonKaydol = new Button();
            buttonGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 114);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanici Adi: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 170);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Sifre:";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(201, 111);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(153, 27);
            textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(201, 170);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(153, 27);
            textBoxSifre.TabIndex = 3;
            // 
            // buttonKaydol
            // 
            buttonKaydol.Location = new Point(164, 235);
            buttonKaydol.Name = "buttonKaydol";
            buttonKaydol.Size = new Size(94, 29);
            buttonKaydol.TabIndex = 4;
            buttonKaydol.Text = "Kaydol";
            buttonKaydol.UseVisualStyleBackColor = true;
            buttonKaydol.Click += buttonKaydol_Click;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(264, 235);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(94, 29);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giris";
            buttonGiris.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 376);
            Controls.Add(buttonGiris);
            Controls.Add(buttonKaydol);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Button buttonKaydol;
        private Button buttonGiris;
    }
}