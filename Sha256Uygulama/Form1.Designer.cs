namespace Sha256Uygulama
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
            textBoxMetin = new TextBox();
            textBoxKod = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxMetin
            // 
            textBoxMetin.Location = new Point(30, 118);
            textBoxMetin.Name = "textBoxMetin";
            textBoxMetin.Size = new Size(246, 27);
            textBoxMetin.TabIndex = 0;
            // 
            // textBoxKod
            // 
            textBoxKod.Location = new Point(538, 118);
            textBoxKod.Name = "textBoxKod";
            textBoxKod.Size = new Size(463, 27);
            textBoxKod.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(313, 118);
            button1.Name = "button1";
            button1.Size = new Size(182, 29);
            button1.TabIndex = 2;
            button1.Text = "SHA256 Kod Uret";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 450);
            Controls.Add(button1);
            Controls.Add(textBoxKod);
            Controls.Add(textBoxMetin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMetin;
        private TextBox textBoxKod;
        private Button button1;
    }
}