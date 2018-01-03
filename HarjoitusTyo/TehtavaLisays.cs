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
    public partial class TehtavaLisays : Form
    {
        Aloitus parent = null;

        public TehtavaLisays(Aloitus parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "INSERT INTO tehtavat(tehtava_nimi, tehtava_kuvaus)" + 
                    "VALUES('"+ this.tbTehtavaNimi.Text + "','" + this.tbTehtavaKuvaus.Text + "')";

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

            tbTehtavaNimi.Text = String.Empty;
            tbTehtavaKuvaus.Text = String.Empty;
        }

        private void btnTarkasteleTehtavia_Click(object sender, EventArgs e)
        {
            TehtavaTarkastelu t = new TehtavaTarkastelu(this);
            t.Show();
        }
    }
}
