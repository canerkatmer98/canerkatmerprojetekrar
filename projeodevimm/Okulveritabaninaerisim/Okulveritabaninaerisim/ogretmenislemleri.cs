using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Okulveritabaninaerisim
{
    public partial class ogretmenislemleri : Form
    {
        public ogretmenislemleri()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        void temizle()
        {
            anan.Clear(); ad.Clear(); adres.Clear(); sifre.Clear(); maastxt.Clear(); soyad.Clear(); kadi.Clear(); brans.Text = ""; ;
            dt.Format = DateTimePickerFormat.Short;
            dt.CustomFormat = " ";
        }
        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From ogretmen_bilgi ", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ogrtmlist.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void ogretmenislemleri_Load(object sender, EventArgs e)
        {
            int a;
            string cnstr = "Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            string query = "select Max(Id) from ogretmen_bilgi";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    anan.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;

                    anan.Text = a.ToString();
                }
              
            }
            listele();

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string id = anan.Text;
            int a = Int32.Parse(id);
            string adi = ad.Text;
            string soyadi = soyad.Text;
            string kullanciadi = kadi.Text;
            string sfr = sifre.Text;
            string maas = maastxt.Text;
            string brns = brans.Text;
            string adress = adres.Text;
            string dtt = dt.Text;
            database ogrtmnekle = new database();
            ogrtmnekle.kayitekle(a, adi, soyadi, kullanciadi, sfr,maas, adress, brns, dtt, this);
            this.Close();
            ogretmenislemleri tekrar = new ogretmenislemleri();
            tekrar.ShowDialog();
            listele();
            temizle();
        }

        private void ogrtmlist_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ogrtmlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = ogrtmlist.SelectedCells[0].RowIndex;
            string x0 = ogrtmlist.Rows[x].Cells[0].Value.ToString();
            string x1 = ogrtmlist.Rows[x].Cells[1].Value.ToString();
            string x2 = ogrtmlist.Rows[x].Cells[2].Value.ToString();
            string x3 = ogrtmlist.Rows[x].Cells[3].Value.ToString();
            string x4 = ogrtmlist.Rows[x].Cells[4].Value.ToString();
            string x5 = ogrtmlist.Rows[x].Cells[5].Value.ToString();
            string x6 = ogrtmlist.Rows[x].Cells[6].Value.ToString();
            string x7 = ogrtmlist.Rows[x].Cells[7].Value.ToString();
            string x8 = ogrtmlist.Rows[x].Cells[8].Value.ToString();
            anan.Text = x0;
            ad.Text = x1;
            soyad.Text = x2;
            kadi.Text = x3;
            sifre.Text = x4;
            maastxt.Text = x5;
            adres.Text = x6;
            brans.Text = x7;
            dt.Text = x8;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string a = anan.Text;
            int x = Int32.Parse(a);
            database sil = new database();
            sil.silogrtmn(x, this);
            listele();
            temizle();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ogretmen_bilgi Where Id='" + ara.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ogrtmlist.DataSource = ds.Tables[0];
            baglan.Close();
            temizle();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            string id = anan.Text;
            int a = Int32.Parse(id);
            string isim = ad.Text;
            string soyisim = soyad.Text;
            string kadi1 = kadi.Text;
            string sfr = sifre.Text;
            string maas = maastxt.Text;
            string adrs = adres.Text;
            string brns = brans.Text;
            string dtt = dt.Text;
            database dtb = new database();
            dtb.guncelleogrtmn( isim, soyisim, kadi1, sfr, maas, adrs, brns, dtt, a, this);
            listele();
            temizle();
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
