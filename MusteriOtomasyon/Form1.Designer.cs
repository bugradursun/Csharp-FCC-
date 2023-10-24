namespace MusteriOtomasyon
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonTemizle = new Button();
            buttonEkle = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxSehir = new TextBox();
            textBoxKrediyeUygunMu = new TextBox();
            textBoxAylikGelir = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            textBoxMusteriId = new TextBox();
            buttonSil = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 321);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonSil);
            panel2.Controls.Add(buttonTemizle);
            panel2.Controls.Add(buttonEkle);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxSehir);
            panel2.Controls.Add(textBoxKrediyeUygunMu);
            panel2.Controls.Add(textBoxAylikGelir);
            panel2.Controls.Add(textBoxSoyad);
            panel2.Controls.Add(textBoxAd);
            panel2.Controls.Add(textBoxMusteriId);
            panel2.Location = new Point(13, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 154);
            panel2.TabIndex = 1;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(511, 62);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(94, 29);
            buttonTemizle.TabIndex = 13;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(511, 24);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(94, 29);
            buttonEkle.TabIndex = 12;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 99);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 11;
            label6.Text = "Sehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 62);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 10;
            label5.Text = "Kredi Uygunlugu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 29);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Aylik Gelir:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 66);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 7;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Musteri Id:";
            // 
            // textBoxSehir
            // 
            textBoxSehir.Location = new Point(342, 92);
            textBoxSehir.Name = "textBoxSehir";
            textBoxSehir.Size = new Size(125, 27);
            textBoxSehir.TabIndex = 5;
            // 
            // textBoxKrediyeUygunMu
            // 
            textBoxKrediyeUygunMu.Enabled = false;
            textBoxKrediyeUygunMu.Location = new Point(342, 59);
            textBoxKrediyeUygunMu.Name = "textBoxKrediyeUygunMu";
            textBoxKrediyeUygunMu.Size = new Size(125, 27);
            textBoxKrediyeUygunMu.TabIndex = 4;
            // 
            // textBoxAylikGelir
            // 
            textBoxAylikGelir.Location = new Point(342, 26);
            textBoxAylikGelir.Name = "textBoxAylikGelir";
            textBoxAylikGelir.Size = new Size(125, 27);
            textBoxAylikGelir.TabIndex = 3;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(86, 92);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(125, 27);
            textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(86, 59);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(125, 27);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxMusteriId
            // 
            textBoxMusteriId.Enabled = false;
            textBoxMusteriId.Location = new Point(87, 26);
            textBoxMusteriId.Name = "textBoxMusteriId";
            textBoxMusteriId.Size = new Size(125, 27);
            textBoxMusteriId.TabIndex = 0;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(511, 101);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 29);
            buttonSil.TabIndex = 14;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxSehir;
        private TextBox textBoxKrediyeUygunMu;
        private TextBox textBoxAylikGelir;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private TextBox textBoxMusteriId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonEkle;
        private Button buttonTemizle;
        private Button buttonSil;
    }
}