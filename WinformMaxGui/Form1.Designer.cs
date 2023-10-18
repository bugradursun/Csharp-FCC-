namespace WinformMaxGui
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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 323);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(35, 83);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 1;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(35, 29);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 0;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(649, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 445);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 105);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(14, 47);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(12, 332);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 116);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Location = new Point(478, 77);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 2;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(478, 38);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(478, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(399, 271);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
    }
}