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
    public partial class ogretmensecim : Form
    {
        public ogretmensecim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogretmenform2 og2 = new ogretmenform2();
            og2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogretmenform1 og1 = new ogretmenform1();
            og1.ShowDialog();
        }

        private void ogretmensecim_Load(object sender, EventArgs e)
        {
            label1.Text = ogretmengiris.ogrtkadi;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Girisekrani t = new Girisekrani();
            t.ShowDialog();
        }
    }
}
