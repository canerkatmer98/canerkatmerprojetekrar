using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Okulveritabaninaerisim
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        public static string gykadi;
        private void Giris_Click(object sender, EventArgs e)
        {
            string kadii = kadi.Text;
            string sifree = sifre.Text;
            database giris = new database();
            giris.giris(kadii,sifree,this);
            
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            Girisekrani t = new Girisekrani();
            t.ShowDialog();
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
