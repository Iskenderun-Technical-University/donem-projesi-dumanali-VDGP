namespace VdgpProje
{
    partial class Form2
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
            textAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textSoyad = new TextBox();
            textTelefon = new TextBox();
            textEmail = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            comboBoxMarkasi = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxModeli = new ComboBox();
            label10 = new Label();
            comboBoxArizasi = new ComboBox();
            label11 = new Label();
            richTextBoxArızaDetay = new RichTextBox();
            buttonEkle = new Button();
            buttonGuncelle = new Button();
            buttonSil = new Button();
            buttonYenile = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 71);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            // 
            // textAd
            // 
            textAd.Location = new Point(140, 68);
            textAd.Name = "textAd";
            textAd.Size = new Size(190, 27);
            textAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 27);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Müşterinin ;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 269);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "İletişim ;";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 308);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Telefon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 348);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 9;
            label6.Text = "E-mail :";
            // 
            // textSoyad
            // 
            textSoyad.Location = new Point(140, 108);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(190, 27);
            textSoyad.TabIndex = 10;
            textSoyad.TextChanged += textSoyad_TextChanged;
            // 
            // textTelefon
            // 
            textTelefon.Location = new Point(140, 308);
            textTelefon.Name = "textTelefon";
            textTelefon.Size = new Size(190, 27);
            textTelefon.TabIndex = 11;
            textTelefon.TextChanged += textTelefon_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(140, 348);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(190, 27);
            textEmail.TabIndex = 12;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(738, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 478);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(846, 445);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Girdiler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(843, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxMarkasi
            // 
            comboBoxMarkasi.FormattingEnabled = true;
            comboBoxMarkasi.Location = new Point(463, 61);
            comboBoxMarkasi.Name = "comboBoxMarkasi";
            comboBoxMarkasi.Size = new Size(223, 28);
            comboBoxMarkasi.TabIndex = 14;
            comboBoxMarkasi.SelectedIndexChanged += comboBoxMarkasi_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 27);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 15;
            label7.Text = "Cihazın ;";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 69);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 16;
            label8.Text = "Markası :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(364, 115);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 17;
            label9.Text = "Modeli :";
            // 
            // comboBoxModeli
            // 
            comboBoxModeli.FormattingEnabled = true;
            comboBoxModeli.Location = new Point(463, 108);
            comboBoxModeli.Name = "comboBoxModeli";
            comboBoxModeli.Size = new Size(223, 28);
            comboBoxModeli.TabIndex = 18;
            comboBoxModeli.SelectedIndexChanged += comboBoxModeli_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(364, 280);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 19;
            label10.Text = "Arızası :";
            // 
            // comboBoxArizasi
            // 
            comboBoxArizasi.FormattingEnabled = true;
            comboBoxArizasi.Location = new Point(463, 269);
            comboBoxArizasi.Name = "comboBoxArizasi";
            comboBoxArizasi.Size = new Size(223, 28);
            comboBoxArizasi.TabIndex = 20;
            comboBoxArizasi.SelectedIndexChanged += comboBoxArizasi_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(364, 326);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 21;
            label11.Text = "Arıza Detay :";
            // 
            // richTextBoxArızaDetay
            // 
            richTextBoxArızaDetay.Location = new Point(463, 326);
            richTextBoxArızaDetay.Name = "richTextBoxArızaDetay";
            richTextBoxArızaDetay.Size = new Size(223, 155);
            richTextBoxArızaDetay.TabIndex = 22;
            richTextBoxArızaDetay.Text = "";
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(83, 436);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(94, 45);
            buttonEkle.TabIndex = 23;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(183, 436);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(94, 45);
            buttonGuncelle.TabIndex = 24;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(283, 436);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 45);
            buttonSil.TabIndex = 25;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonYenile
            // 
            buttonYenile.Location = new Point(1127, 487);
            buttonYenile.Name = "buttonYenile";
            buttonYenile.Size = new Size(94, 45);
            buttonYenile.TabIndex = 26;
            buttonYenile.Text = "Yenile";
            buttonYenile.UseVisualStyleBackColor = true;
            buttonYenile.Click += buttonYenile_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1604, 591);
            Controls.Add(buttonYenile);
            Controls.Add(buttonSil);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonEkle);
            Controls.Add(richTextBoxArızaDetay);
            Controls.Add(label11);
            Controls.Add(comboBoxArizasi);
            Controls.Add(label10);
            Controls.Add(comboBoxModeli);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxMarkasi);
            Controls.Add(tabControl1);
            Controls.Add(textEmail);
            Controls.Add(textTelefon);
            Controls.Add(textSoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textAd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textSoyad;
        private TextBox textTelefon;
        private TextBox textEmail;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxMarkasi;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxModeli;
        private Label label10;
        private ComboBox comboBoxArizasi;
        private Label label11;
        private RichTextBox richTextBoxArızaDetay;
        private Button buttonEkle;
        private Button buttonGuncelle;
        private Button buttonSil;
        private DataGridView dataGridView1;
        private Button buttonYenile;
    }
}