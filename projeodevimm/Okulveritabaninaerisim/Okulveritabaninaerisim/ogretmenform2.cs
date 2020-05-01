using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Okulveritabaninaerisim
{
    public partial class ogretmenform2 : Form
    {
        public ogretmenform2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");

        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Adi,Soyadi,Okulno,Sinif From ogrenci_bilgileri ", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogretmenform2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Adi,Soyadi,Okulno,Sinif from ogrenci_bilgileri Where Okulno='" + araa.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogretmensecim os = new ogretmensecim();
            os.ShowDialog();
        }
    }
}
