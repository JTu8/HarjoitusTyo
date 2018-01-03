using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarjoitusTyo
{
    public partial class ProjektiLisays : Form
    {
        Aloitus parent = null;

        public ProjektiLisays(Aloitus parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnLisaaProjekti_Click(object sender, EventArgs e)
        {
            //DBConnect c = new DBConnect();
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";
            string vDate = DateTime.Parse(selectDate.Text).ToString("yyyy-MM-dd");

            try
            {
                string query = "INSERT INTO projektitiedot(projekti_nimi, aloituspvm, kuvaus)" + 
                    "VALUES('"+ this.tbProjektiNimi.Text + "','" + vDate + "','" + this.tbKuvaus.Text + "');";

                

                //c.Initialize();
                MySqlConnection myCon = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                myCon.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Tiedot tallennettu");
                while(myReader.Read())
                {

                }
                myCon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbProjektiNimi.Text = String.Empty;
            tbKuvaus.Text = String.Empty;
        }

        private void btnTarkasteleProjekteja_Click(object sender, EventArgs e)
        {
            ProjektiTarkastelu p = new ProjektiTarkastelu(this);
            p.Show();
        }

        private void projektinTehtävätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TehtavaProjektiin t = new TehtavaProjektiin();
            DialogResult res;
            res = t.ShowDialog();
        }
    }
}
