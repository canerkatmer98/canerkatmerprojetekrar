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

namespace Okulveritabaninaerisim
{
    public partial class yonetici_islemleri : Form
    {
        public yonetici_islemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");

        void temizle()
        {
            id.Clear(); ad.Clear(); soyad.Clear(); kadi.Clear(); sifre.Clear();
        }
        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From yonetici_giris_bilgileri ", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            yoneticilist.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = id.Text;
            int id1 = Int32.Parse(a);
            string adi = ad.Text;
            string sadi = soyad.Text;
            string kadi1 = kadi.Text;
            string sfr = sifre.Text;
            database ogrk = new database();
            ogrk.kayitekleyonetici(id1, adi, sadi, kadi1, sfr, this);
            yonetici_islemleri l = new yonetici_islemleri();
            this.Hide();
            l.ShowDialog();
            listele();
            temizle();
        }

        private void yoneticilist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = yoneticilist.SelectedCells[0].RowIndex;
            string x0 = yoneticilist.Rows[x].Cells[0].Value.ToString();
            string x1 = yoneticilist.Rows[x].Cells[1].Value.ToString();
            string x2 = yoneticilist.Rows[x].Cells[2].Value.ToString();
            string x3 = yoneticilist.Rows[x].Cells[3].Value.ToString();
            string x4 = yoneticilist.Rows[x].Cells[4].Value.ToString();
           
            id.Text = x0;
            ad.Text = x1;
            soyad.Text = x2;
            kadi.Text = x3;
            sifre.Text = x4;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = id.Text;
            int x = Int32.Parse(a);
            database sil = new database();
            sil.silyntc(x, this);
            listele();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = id.Text;
            int x = Int32.Parse(a);
            string adi = ad.Text;
            string soyadi = soyad.Text;
            string kadi1 = kadi.Text;
            string sfr = sifre.Text;
            database dtb = new database();
            dtb.guncelleyntc(adi, soyadi, kadi1, sfr, x, this);
            listele();
            temizle();
        }

        private void yonetici_islemleri_Load(object sender, EventArgs e)
        {

            int a;
            string cnstr = "Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            string query = "select Max(Cast(Id as Int)) from yonetici_giris_bilgileri";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    id.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    id.Text = a.ToString();
                }
            }
            listele();
        }

        private void yoneticilist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from yonetici_giris_bilgileri Where Id='" + ara.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            yoneticilist.DataSource = ds.Tables[0];
            baglan.Close();
            temizle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yoneticiform1 t = new Yoneticiform1();
            t.ShowDialog();
        }
    }
}
