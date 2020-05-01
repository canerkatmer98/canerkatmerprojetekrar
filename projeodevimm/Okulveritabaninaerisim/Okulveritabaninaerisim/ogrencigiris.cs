using Okulveritabaninaerisim.Classlar;
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
    public partial class ogrencigiris : Form
    {
        public ogrencigiris()
        {
            InitializeComponent();
        }
        public static string ogrkadi;
        private void button1_Click(object sender, EventArgs e)
        {
            string ogrkadi = kadi.Text;
            string ogrsifre = sifre.Text;
            ogrform1 dt = new ogrform1();
            dt.ogrgiris(ogrkadi,ogrsifre,this);
        }

        private void kadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrencigiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
