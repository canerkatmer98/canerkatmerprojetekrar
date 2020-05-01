using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okulveritabaninaerisim
{
    public partial class ogretmengiris : Form
    {
        public ogretmengiris()
        {
            InitializeComponent();
        }
        public static string ogrtkadi;
        private void ogretmengiris_Load(object sender, EventArgs e)

        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
              string kadi1 = kadi.Text;
            string sifre1 = sifre.Text;
            database ogrtmngrs = new database();
            ogrtmngrs.ogrtmngiris(kadi1, sifre1, this);
        }

        private void kadi_TextChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Girisekrani t = new Girisekrani();
            t.ShowDialog();
        }
    }
}
