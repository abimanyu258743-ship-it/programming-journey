using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_akhir_abimanyu_X_PPLG_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Rendang", "20.000", "Es Teh", "3.000");
            dataGridView1.Rows.Add("Ayam Gulai", "18.000", "Es Jeruk", "4.000");
            dataGridView1.Rows.Add("Telur Balado", "13.000", "Teh Anget", "3.000");
            dataGridView1.Rows.Add("Gulai Tunjang", "15.000", "Es Susu", "4.000");
            dataGridView1.Rows.Add("Ayam Pop", "18.000", "Kopi Susu", "5.000");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else
                 MessageBox.Show("Pilih baris pesanan yang ingin dihapus");
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void iblHarga_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_makanan = comboBox1.SelectedItem?.ToString();
            string nama_minuman = comboBox2.SelectedItem?.ToString();
            int porsi_mamam = 0;
            int porsi_mimik = 0;
            if (!string.IsNullOrEmpty(comboBox4.Text))
            { 
                porsi_mamam = Convert.ToInt32(comboBox4.Text);
            }
            if (!string.IsNullOrEmpty(comboBox3.Text))
            {
                porsi_mimik = Convert.ToInt32(comboBox3.Text);
            }
            int harga_makanan = 0;
            int harga_minuman = 0;
            if(nama_makanan == "Rendang")
            {
                harga_makanan = 20000 * porsi_mamam;
            }
            if(nama_minuman == "Es Teh")
            {
                harga_minuman = 3000 * porsi_mimik;
            }
            if (nama_makanan == "Ayam Gulai")
            {
                harga_makanan = 18000 * porsi_mamam;
            }
            if (nama_minuman == "Es Jeruk")
            {
                harga_minuman = 4000 * porsi_mimik;
            }
            if (nama_makanan == "Telur Balado")
            {
                harga_makanan = 13000 * porsi_mamam;
            }
            if (nama_minuman == "Teh Anget")
            {
                harga_minuman = 3000 * porsi_mimik;
            }
            if (nama_makanan == "Gulai Tunjang")
            {
                harga_makanan = 15000 * porsi_mamam;
            }
            if (nama_minuman == "Es Susu")
            {
                harga_minuman = 4000 * porsi_mimik;
            }
            if (nama_makanan == "Ayam Pop")
            {
                harga_makanan = 18000 * porsi_mamam;
            }
            if (nama_minuman == "Kopi Susu")
            {
                harga_minuman = 5000 * porsi_mimik;
            }

            int total_harga = harga_minuman + harga_makanan;
            dataGridView2.Rows.Add(nama_makanan, porsi_mamam, nama_minuman, porsi_mimik, total_harga);
            txtTotal.Text = $"{Convert.ToInt32(txtTotal.Text) + total_harga}";
             


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //Menghitung kembalian
            if (!string.IsNullOrEmpty(txtBayar.Text))
            {
                if (Convert.ToDouble(txtBayar.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Uangnya kurang kak");
                    return;
                }

                double kembalian = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text);
                lblkembalian.Text = $"{kembalian.ToString("N0")}";
            }
            else MessageBox.Show("Total bayar tidak dapat terdefinisikan!");
            return;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblkembalian_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
