namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Gerekli tasarım bileşenleri.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Kaynakları temizler.
        /// </summary>
        /// <param name="disposing">true, yönetilen kaynaklar temizleniyorsa; aksi takdirde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnAdSoyad = new System.Windows.Forms.ColumnHeader();
            this.columnDogumTarihi = new System.Windows.Forms.ColumnHeader();
            this.columnBoyKilo = new System.Windows.Forms.ColumnHeader();
            this.columnVki = new System.Windows.Forms.ColumnHeader();
            this.columnVkiYorum = new System.Windows.Forms.ColumnHeader();
            this.columnBurc = new System.Windows.Forms.ColumnHeader();
            this.columnBurcYorum = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.textBoxWeight);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Ad";
            this.textBoxName.Size = new System.Drawing.Size(114, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(126, 55);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PlaceholderText = "Soyad";
            this.textBoxSurname.Size = new System.Drawing.Size(114, 23);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(6, 110);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.PlaceholderText = "Boy (cm)";
            this.textBoxHeight.Size = new System.Drawing.Size(114, 23);
            this.textBoxHeight.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(126, 110);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.PlaceholderText = "Kilo (kg)";
            this.textBoxWeight.Size = new System.Drawing.Size(114, 23);
            this.textBoxWeight.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAdSoyad,
            this.columnDogumTarihi,
            this.columnBoyKilo,
            this.columnVki,
            this.columnVkiYorum,
            this.columnBurc,
            this.columnBurcYorum});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1030, 200);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnAdSoyad
            // 
            this.columnAdSoyad.Text = "Ad Soyad";
            this.columnAdSoyad.Width = 120;
            // 
            // columnDogumTarihi
            // 
            this.columnDogumTarihi.Text = "Doğum Tarihi";
            this.columnDogumTarihi.Width = 120;
            // 
            // columnBoyKilo
            // 
            this.columnBoyKilo.Text = "Boy/Kilo";
            this.columnBoyKilo.Width = 100;
            // 
            // columnVki
            // 
            this.columnVki.Text = "VKİ";
            this.columnVki.Width = 80;
            // 
            // columnVkiYorum
            // 
            this.columnVkiYorum.Text = "VKİ Yorum";
            this.columnVkiYorum.Width = 120;
            // 
            // columnBurc
            // 
            this.columnBurc.Text = "Burç";
            this.columnBurc.Width = 80;
            // 
            // columnBurcYorum
            // 
            this.columnBurcYorum.Text = "Burç Yorum";
            this.columnBurcYorum.Width = 200;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnAdSoyad;
        private System.Windows.Forms.ColumnHeader columnDogumTarihi;
        private System.Windows.Forms.ColumnHeader columnBoyKilo;
        private System.Windows.Forms.ColumnHeader columnVki;
        private System.Windows.Forms.ColumnHeader columnVkiYorum;
        private System.Windows.Forms.ColumnHeader columnBurc;
        private System.Windows.Forms.ColumnHeader columnBurcYorum;
    }
}
