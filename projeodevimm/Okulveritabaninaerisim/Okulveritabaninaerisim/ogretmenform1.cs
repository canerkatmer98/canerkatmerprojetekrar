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
    public partial class ogretmenform1 : Form
    {
        public ogretmenform1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
    
        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From ogretmen_bilgi where Adi = '" + label1.Text + "'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ogrlistele.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void ogretmenform1_Load(object sender, EventArgs e)
        {
            
            label1.Text = ogretmengiris.ogrtkadi;
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
        private void ogrlistele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string idd = id.Text;
            int x = Int32.Parse(idd);
            string adi = ad.Text;
            string sad = soyad.Text;
            string kadi1 = kadi.Text;
            string sfr = sifre.Text;
            string adr = adres.Text;
           ogretmen ogrt = new ogretmen();
            ogrt.ogrtmngncl(adi,sad,kadi1,sfr,adr,x,this);
           
        }

        private void ogrlistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = ogrlistele.SelectedCells[0].RowIndex;
            string x0 = ogrlistele.Rows[x].Cells[0].Value.ToString();
            string x1 = ogrlistele.Rows[x].Cells[1].Value.ToString();
            string x2 = ogrlistele.Rows[x].Cells[2].Value.ToString();
            string x3 = ogrlistele.Rows[x].Cells[3].Value.ToString();
            string x4 = ogrlistele.Rows[x].Cells[4].Value.ToString();
            string x5 = ogrlistele.Rows[x].Cells[5].Value.ToString();
            id.Text = x0;
            ad.Text = x1;
            soyad.Text = x2;
            kadi.Text = x3;
            sifre.Text = x4;
            adres.Text = x5;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogretmensecim os = new ogretmensecim();
            os.ShowDialog();
        }
    }
}
