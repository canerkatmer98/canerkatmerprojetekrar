using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Okulveritabaninaerisim.Classlar
{
    class ogretmen
    {

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        public void ogrtmngncl(string adi, string soyadi,string kadi,string sifre, string adres, int id, Form frm)
        {
            baglan.Open();
            string query = "Update ogretmen_bilgi Set  Adi='" + adi + "',Soyadi='" + soyadi + "',Kullaniciadi='" +kadi + "',Sifre='" + sifre + "',Adres='" + adres + "'WHERE Id='" + id + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
