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
    public partial class ogrenci_islemleri : Form
    {
        public ogrenci_islemleri()
        {
            InitializeComponent();
        }

      
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        void temizle()
        {
            id.Clear(); Ad.Clear(); Soyad.Clear(); on.Clear();kadi1.Clear(); sifretxt.Clear(); snf.Text = ""; ;
            dt.Format = DateTimePickerFormat.Short;
            dt.CustomFormat = " ";
        }
        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From ogrenci_bilgileri ", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ogrenciliste.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void ogrenci_islemleri_Load(object sender, EventArgs e)
        {
            int a;
            string cnstr = "Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            string query = "select Max(Cast(Id as Int)) from ogrenci_bilgileri";
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
                listele();
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string ad = Ad.Text;
            string soyad = Soyad.Text;
            string okulno = on.Text;
            string kullaniciadi = kadi1.Text;
            string sifre = sifretxt.Text;
            string sinif = snf.Text;
            string a = id.Text;
            int x = Int32.Parse(a);
            string dgm = dt.Text;
            database ogrk = new database();
            ogrk.ekle(ad, soyad, x,okulno,kullaniciadi,sifre,sinif,dgm, this);
            ogrenci_islemleri l = new ogrenci_islemleri();
            this.Hide();
            l.ShowDialog();
            listele();
            temizle();
        } 
        private void ogrenciliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = ogrenciliste.SelectedCells[0].RowIndex;
            string x0 = ogrenciliste.Rows[x].Cells[0].Value.ToString();
            string x1 = ogrenciliste.Rows[x].Cells[1].Value.ToString();
            string x2 = ogrenciliste.Rows[x].Cells[2].Value.ToString();
            string x3 = ogrenciliste.Rows[x].Cells[3].Value.ToString();
            string x4 = ogrenciliste.Rows[x].Cells[4].Value.ToString();
            string x5 = ogrenciliste.Rows[x].Cells[5].Value.ToString();
            string x6 = ogrenciliste.Rows[x].Cells[6].Value.ToString();
            string x7 = ogrenciliste.Rows[x].Cells[7].Value.ToString();
            id.Text = x0;
            Ad.Text = x1;
            Soyad.Text = x2;
            on.Text = x3;
            kadi1.Text = x4;
            sifretxt.Text = x5;
            snf.Text = x6;
            dt.Text = x7;
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            string a = id.Text;
            int y = Int32.Parse(a);
            string adi = Ad.Text;
            string soyadi = Soyad.Text;
            string oon = on.Text;
            string kadi = kadi1.Text;
            string sifre= sifretxt.Text;
            string sinif = snf.Text;
            string dtt = dt.Text;
            database dtb = new database();
            dtb.guncelle(adi,soyadi,oon,kadi,sifre,sinif,dtt, y,this);
            listele();
            temizle();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string a = id.Text;
            int x = Int32.Parse(a);
            database sil = new database();
            sil.sil(x, this);
            listele();
            temizle();
        }

        private void araa_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ogrenci_bilgileri Where Id='" + ara.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ogrenciliste.DataSource = ds.Tables[0];
            baglan.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ogrenciliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yoneticiform1 t = new Yoneticiform1();
            t.ShowDialog();
        }
    }
}
