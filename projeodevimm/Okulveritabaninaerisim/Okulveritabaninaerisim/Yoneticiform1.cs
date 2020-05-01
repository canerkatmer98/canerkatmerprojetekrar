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
    public partial class Yoneticiform1 : Form
    {
        public Yoneticiform1()
        {
            InitializeComponent();
        }

        private void Yoneticiform1_Load(object sender, EventArgs e)
        {
            label1.Text = YoneticiGiris.gykadi;
            label4.Text = YoneticiGiris.gykadi;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ogrenci_Click(object sender, EventArgs e)
        {
            ogrenci_islemleri oi = new ogrenci_islemleri();
            this.Hide();
            oi.ShowDialog();
        }

        private void ogretmen_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogretmenislemleri oi = new ogretmenislemleri();
            oi.ShowDialog();
        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici_islemleri yg = new yonetici_islemleri();
            yg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ybilgi yb = new ybilgi();
            yb.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Girisekrani t = new Girisekrani();
            t.ShowDialog();
        }
    }
}
