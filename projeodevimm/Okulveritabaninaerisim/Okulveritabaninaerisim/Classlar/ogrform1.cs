using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Okulveritabaninaerisim.Classlar
{
    class ogrform1
    {

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        SqlCommand kod;
        SqlDataReader oku;
        public void ogrgiris(string kadi, string sifre, Form frm1)
        {
            kod = new SqlCommand("Select * from ogrenci_bilgileri where Kullaniciadi='" + kadi + "'and Sifre='" + sifre + "'", baglan);
            baglan.Open();
            oku = kod.ExecuteReader();
            if (oku.Read())
            {
                ogrencigiris.ogrkadi = oku["Kullaniciadi"].ToString();
                ogrenciform1 yf = new ogrenciform1();
                frm1.Hide();
                yf.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            baglan.Close();
            kod.Dispose();
        }
        public void ogrgncl(string kadi, string sifre, int id, Form frm)
        {
            baglan.Open();
            string query = "Update ogrenci_bilgileri Set  Kullaniciadi='" + kadi + "',Sifre='" + sifre + "'WHERE Id='" + id + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
