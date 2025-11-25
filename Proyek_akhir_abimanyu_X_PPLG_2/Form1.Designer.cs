namespace Proyek_akhir_abimanyu_X_PPLG_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.iblPesan = new System.Windows.Forms.Label();
            this.iblNama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iblHarga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Makanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makanan_Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minuman_Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Makanan_ih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porsi_ih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minuman_ih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porsi_ah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkembalian = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iblPesan
            // 
            this.iblPesan.AutoSize = true;
            this.iblPesan.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblPesan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iblPesan.Location = new System.Drawing.Point(377, 25);
            this.iblPesan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iblPesan.Name = "iblPesan";
            this.iblPesan.Size = new System.Drawing.Size(450, 43);
            this.iblPesan.TabIndex = 0;
            this.iblPesan.Text = "MENU MASAKAN PADANG";
            this.iblPesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iblPesan.Click += new System.EventHandler(this.label1_Click);
            // 
            // iblNama
            // 
            this.iblNama.AutoSize = true;
            this.iblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblNama.Location = new System.Drawing.Point(7, 32);
            this.iblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iblNama.Name = "iblNama";
            this.iblNama.Size = new System.Drawing.Size(76, 20);
            this.iblNama.TabIndex = 1;
            this.iblNama.Text = "Masakan";
            this.iblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iblNama.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iblHarga
            // 
            this.iblHarga.AutoSize = true;
            this.iblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblHarga.Location = new System.Drawing.Point(7, 93);
            this.iblHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iblHarga.Name = "iblHarga";
            this.iblHarga.Size = new System.Drawing.Size(48, 20);
            this.iblHarga.TabIndex = 3;
            this.iblHarga.Text = "Porsi";
            this.iblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iblHarga.Click += new System.EventHandler(this.iblHarga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minuman";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rendang",
            "Ayam Gulai",
            "Telur Balado",
            "Gulai Tunjang",
            "Ayam Pop"});
            this.comboBox1.Location = new System.Drawing.Point(91, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 31);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Es Teh",
            "Es Jeruk",
            "Teh Panas",
            "Es Susu",
            "Kopi Susu"});
            this.comboBox2.Location = new System.Drawing.Point(91, 137);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 31);
            this.comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Porsi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox3.Location = new System.Drawing.Point(91, 203);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(203, 31);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox4.Location = new System.Drawing.Point(91, 86);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(203, 31);
            this.comboBox4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "PESAN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(177, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "BATALKAN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iblNama);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.iblHarga);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 294);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makanan,
            this.Makanan_Harga,
            this.minuman,
            this.Minuman_Harga});
            this.dataGridView1.Location = new System.Drawing.Point(12, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 167);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Makanan
            // 
            this.Makanan.HeaderText = "Makanan";
            this.Makanan.MinimumWidth = 6;
            this.Makanan.Name = "Makanan";
            this.Makanan.ReadOnly = true;
            this.Makanan.Width = 125;
            // 
            // Makanan_Harga
            // 
            this.Makanan_Harga.HeaderText = "Harga Makanan";
            this.Makanan_Harga.MinimumWidth = 6;
            this.Makanan_Harga.Name = "Makanan_Harga";
            this.Makanan_Harga.ReadOnly = true;
            this.Makanan_Harga.Width = 125;
            // 
            // minuman
            // 
            this.minuman.HeaderText = "Minuman";
            this.minuman.MinimumWidth = 6;
            this.minuman.Name = "minuman";
            this.minuman.ReadOnly = true;
            this.minuman.Width = 125;
            // 
            // Minuman_Harga
            // 
            this.Minuman_Harga.HeaderText = "Harga Minuman";
            this.Minuman_Harga.MinimumWidth = 6;
            this.Minuman_Harga.Name = "Minuman_Harga";
            this.Minuman_Harga.ReadOnly = true;
            this.Minuman_Harga.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makanan_ih,
            this.Porsi_ih,
            this.Minuman_ih,
            this.Porsi_ah,
            this.total_harga});
            this.dataGridView2.Location = new System.Drawing.Point(552, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(679, 102);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Makanan_ih
            // 
            this.Makanan_ih.HeaderText = "Makanan";
            this.Makanan_ih.MinimumWidth = 6;
            this.Makanan_ih.Name = "Makanan_ih";
            this.Makanan_ih.ReadOnly = true;
            this.Makanan_ih.Width = 125;
            // 
            // Porsi_ih
            // 
            this.Porsi_ih.HeaderText = "Porsi";
            this.Porsi_ih.MinimumWidth = 6;
            this.Porsi_ih.Name = "Porsi_ih";
            this.Porsi_ih.ReadOnly = true;
            this.Porsi_ih.Width = 125;
            // 
            // Minuman_ih
            // 
            this.Minuman_ih.HeaderText = "Minuman";
            this.Minuman_ih.MinimumWidth = 6;
            this.Minuman_ih.Name = "Minuman_ih";
            this.Minuman_ih.ReadOnly = true;
            this.Minuman_ih.Width = 125;
            // 
            // Porsi_ah
            // 
            this.Porsi_ah.HeaderText = "Porsi";
            this.Porsi_ah.MinimumWidth = 6;
            this.Porsi_ah.Name = "Porsi_ah";
            this.Porsi_ah.ReadOnly = true;
            this.Porsi_ah.Width = 125;
            // 
            // total_harga
            // 
            this.total_harga.HeaderText = "Total Harga";
            this.total_harga.MinimumWidth = 6;
            this.total_harga.Name = "total_harga";
            this.total_harga.ReadOnly = true;
            this.total_harga.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblkembalian);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtBayar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(552, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 373);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Uang Kembalian :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblkembalian
            // 
            this.lblkembalian.AutoSize = true;
            this.lblkembalian.Location = new System.Drawing.Point(455, 216);
            this.lblkembalian.Name = "lblkembalian";
            this.lblkembalian.Size = new System.Drawing.Size(0, 23);
            this.lblkembalian.TabIndex = 23;
            this.lblkembalian.Click += new System.EventHandler(this.lblkembalian_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(34, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "Bayar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(246, 143);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(230, 30);
            this.txtBayar.TabIndex = 21;
            this.txtBayar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jumlah Uang Pelanggan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(246, 76);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(230, 30);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Harga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(338, 383);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 25;
            this.button4.Text = "BERSIHKAN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1262, 647);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iblPesan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PESAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iblPesan;
        private System.Windows.Forms.Label iblNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iblHarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makanan_Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minuman_Harga;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makanan_ih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porsi_ih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minuman_ih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porsi_ah;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblkembalian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}

