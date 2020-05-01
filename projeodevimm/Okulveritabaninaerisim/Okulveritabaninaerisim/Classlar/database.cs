using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Okulveritabaninaerisim
{
    class database
    {
        //OGRENCİ DATABASE//

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        SqlCommand kod;
        SqlDataReader oku;

        public void ekle(string adi, string soyadi,int id,string on,string kadi, string sifre, string sinif, string  dt, Form frm)
        {
            baglan.Open();
            string x = "INSERT INTO ogrenci_bilgileri(Adi,Soyadi,Id,Okulno,Kullaniciadi,Sifre,Sinif,DogumTarihi) VALUES('" + adi + "','" + soyadi + "','"+id+"','"+on+"','"+kadi+"','"+sifre+"','"+sinif+"','"+dt+"')";
            SqlDataAdapter da = new SqlDataAdapter(x, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
            da.Dispose();

        }
        public void guncelle(string adi, string soyadi, string on, string kadi, string sfr, string snf, string dt, int id, Form frm)
        {
            baglan.Open();
            string query = "Update ogrenci_bilgileri Set Adi='" + adi + "',Soyadi='" +soyadi+ "',Okulno='"+on+ "',Kullaniciadi='" + kadi+ "',Sifre='" + sfr+ "',Sinif='" + snf+ "',DogumTarihi='"+dt+"'WHERE Id='" + id + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
        public void sil(int id,Form frm)
        {
            baglan.Open();
            string k = "Delete From ogrenci_bilgileri where Id='" + id+ "'";
            SqlDataAdapter da = new SqlDataAdapter(k, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }



        //OGRETMEN DATABASE//

        public void ogrtmngiris(string kadi, string sifre, Form frm1)
        {
            kod = new SqlCommand("Select * from ogretmen_bilgi where Kullaniciadi='" + kadi + "'and Sifre='" + sifre + "'", baglan);
            baglan.Open();
            oku = kod.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("giriş başarılı");
                ogretmengiris.ogrtkadi = oku["Adi"].ToString();
                ogretmensecim ogf = new ogretmensecim();
                frm1.Hide();
                ogf.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            baglan.Close();
            kod.Dispose();
        }
        public void kayitekle(int a, string b, string c, string d, string e, string f, string g, string h, string i,Form fr)
        {
            baglan.Open();
            string x = "INSERT INTO ogretmen_bilgi(Id,Adi,Soyadi,Kullaniciadi,Sifre,Maas,Adres,Brans,DogumTarihi) VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f+ "','" + g + "','" + h + "','"+i+"')";
            SqlDataAdapter da = new SqlDataAdapter(x, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
            da.Dispose();
        }
        public void guncelleogrtmn(string i, string b, string c, string d, string e, string f, string g, string h, int a, Form fr)
        {
            baglan.Open();
            string query = "Update ogretmen_bilgi Set Adi='" +i + "',Soyadi='" + b+ "',Kullaniciadi='" + c+ "',Sifre='" + d+ "',Maas='" + e + "',Adres='" + f +  "',Brans='" + g+ "',DogumTarihi='" + h + "'WHERE Id='" + a + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
        public void silogrtmn(int id, Form frm)
        {
            baglan.Open();
            string k = "Delete From ogretmen_bilgi where Id='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(k, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
        // YONETICI DATABASE
        public void giris(string kadi, string sifre, Form frm1)
        {
            kod = new SqlCommand("Select * from yonetici_giris_bilgileri where Yonetici_Kadi='" + kadi + "'and Yonetici_Sifre='" + sifre + "'", baglan);
            baglan.Open();
            oku = kod.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("giriş başarılı");
                YoneticiGiris.gykadi = oku["Yonetici_Kadi"].ToString();
                Yoneticiform1 yf = new Yoneticiform1();
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

        public void kayitekleyonetici(int a, string b, string c, string d, string e, Form fr)
        {
            baglan.Open();
            string x = "INSERT INTO yonetici_giris_bilgileri (Id,Adi,Soyadi,Yonetici_Kadi,Yonetici_Sifre) VALUES('" + a + "','" +b+ "','"+c+ "','"+d+ "','"+e+"')";
            SqlDataAdapter da = new SqlDataAdapter(x, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
            da.Dispose();
        }
        public void silyntc(int id, Form frm)
        {
            baglan.Open();
            string k = "Delete From yonetici_giris_bilgileri where Id='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(k, baglan);
            da.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
        public void guncelleyntc(string a,string b,string c, string d, int e, Form fr)
        {
            baglan.Open();
            string query = "Update yonetici_giris_bilgileri Set Adi='" + a + "',Soyadi='" + b + "',Yonetici_Kadi='" + c + "',Yonetici_Sifre='" + d + "'WHERE Id='" + e + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, baglan);
            SDA.SelectCommand.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
