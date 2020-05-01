using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Okulveritabaninaerisim.Classlar;

namespace Okulveritabaninaerisim
{
    public partial class ogrenciform1 : Form
    {
        public ogrenciform1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2PED3V9\\SQLEXPRESS;Initial Catalog=okulveritabani;Integrated Security=True");
        void listelee()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From ogrenci_bilgileri where Kullaniciadi = '"+label1.Text+"'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            listele.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x =listele.SelectedCells[0].RowIndex;
            string x0 = listele.Rows[x].Cells[0].Value.ToString();
            string x1 = listele.Rows[x].Cells[1].Value.ToString();
            string x2 = listele.Rows[x].Cells[2].Value.ToString();

            id.Text = x0;
            kadi.Text = x1;
            sifre.Text = x2;

        }

        private void ogrenciform1_Load(object sender, EventArgs e)
        {
            label1.Text = ogrencigiris.ogrkadi;
                listelee();

            }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string id1 = id.Text;
            int x = Int32.Parse(id1);
            string kullaniciadi = kadi.Text;
            string sifree = sifre.Text;
            ogrform1 of = new ogrform1();
            of.ogrgncl(kullaniciadi,sifree,x,this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            Girisekrani ge = new Girisekrani();
            ge.ShowDialog();
        }
    }
}
