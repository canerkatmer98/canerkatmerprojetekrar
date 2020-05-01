using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Okulveritabaninaerisim.Classlar
{
    class yonetici
    {

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
    
        public void yntgncl(string adi, string soyadi, string kadi, string sifre, int id, Form frm)
        {
            baglan.Open();
            string query = "Update yonetici_giris_bilgileri Set  Adi='" + adi + "',Soyadi='" + soyadi + "',Yonetici_Kadi='" + kadi + "',Yonetici_Sifre='" + sifre +  "'WHERE Id='" + id + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
