namespace DllKullanimProjesi
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
            buttonKareHesapla = new Button();
            buttonKupHesapla = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonKareHesapla
            // 
            buttonKareHesapla.Location = new Point(291, 109);
            buttonKareHesapla.Name = "buttonKareHesapla";
            buttonKareHesapla.Size = new Size(160, 29);
            buttonKareHesapla.TabIndex = 0;
            buttonKareHesapla.Text = "Kare Hesapla";
            buttonKareHesapla.UseVisualStyleBackColor = true;
            buttonKareHesapla.Click += buttonKareHesapla_Click;
            // 
            // buttonKupHesapla
            // 
            buttonKupHesapla.Location = new Point(478, 109);
            buttonKupHesapla.Name = "buttonKupHesapla";
            buttonKupHesapla.Size = new Size(152, 29);
            buttonKupHesapla.TabIndex = 1;
            buttonKupHesapla.Text = "Kup Hesapla";
            buttonKupHesapla.UseVisualStyleBackColor = true;
            buttonKupHesapla.Click += buttonKupHesapla_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(428, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 246);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 4;
            label1.Text = "Sonuc : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonKupHesapla);
            Controls.Add(buttonKareHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKareHesapla;
        private Button buttonKupHesapla;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}