using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarjoitusTyo
{
    public partial class Aloitus : Form
    {
        public Aloitus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLisaaHenkilo_Click(object sender, EventArgs e)
        {
            HenkiloLisays f2 = new HenkiloLisays(this);
            f2.Show();
        }

        private void btnLisaaProjekti_Click(object sender, EventArgs e)
        {
            ProjektiLisays p = new ProjektiLisays(this);
            p.Show();
        }

        private void btnLisaaTehtava_Click(object sender, EventArgs e)
        {
            TehtavaLisays t = new TehtavaLisays(this);
            t.Show();
        }
    }
}
