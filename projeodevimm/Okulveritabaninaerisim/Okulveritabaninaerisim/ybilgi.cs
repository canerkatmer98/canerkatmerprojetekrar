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
using Okulveritabaninaerisim.Classlar;

namespace Okulveritabaninaerisim
{
    public partial class ybilgi : Form
    {
        public ybilgi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");

        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From yonetici_giris_bilgileri where Yonetici_Kadi = '" + label1.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string idd = id.Text;
            int a = Int32.Parse(idd);
            string ism = ad.Text;
            string syd = soyad.Text;
            string kad = kadi.Text;
            string sfr = sifre.Text;
            yonetici yn = new yonetici();
            yn.yntgncl(ism,syd,kad,sfr,a,this);
            label1.Text = kadi.Text;
            listele();
        }

        private void ybilgi_Load(object sender, EventArgs e)
        {
            label1.Text = YoneticiGiris.gykadi;
            listele();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            string x0 = dataGridView1.Rows[x].Cells[0].Value.ToString();
            string x1 = dataGridView1.Rows[x].Cells[1].Value.ToString();
            string x2 = dataGridView1.Rows[x].Cells[2].Value.ToString();
            string x3 = dataGridView1.Rows[x].Cells[3].Value.ToString();
            string x4 = dataGridView1.Rows[x].Cells[4].Value.ToString();
            id.Text = x0;
            ad.Text = x1;
            soyad.Text = x2;
            kadi.Text = x3;
            sifre.Text = x4;
        
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yoneticiform1 t = new Yoneticiform1();
            t.ShowDialog();
        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
