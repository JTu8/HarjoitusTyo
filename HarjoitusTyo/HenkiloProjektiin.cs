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
    public partial class HenkiloProjektiin : Form
    {
        public HenkiloProjektiin()
        {
            InitializeComponent();
        }

        public void NaytaHenkilo()
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";
            try
            {
                MySqlConnection Myconn = new MySqlConnection(conn);
                string Hquery = "SELECT * FROM henkilotiedot;";
                Myconn.Open();
                MySqlCommand myCommand = new MySqlCommand(Hquery, Myconn);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cbHenkilot.Items.Add(myReader.GetString("sukunimi"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NaytaProjekti()
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";
            try
            {
                MySqlConnection MyConn = new MySqlConnection(conn);
                string pQuery = "SELECT * FROM projektitiedot";
                MyConn.Open();
                MySqlCommand myCommand = new MySqlCommand(pQuery, MyConn);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cbProjektit.Items.Add(myReader.GetString("projekti_nimi"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HenkiloProjektiin_Load(object sender, EventArgs e)
        {
            NaytaHenkilo();
            NaytaProjekti();
            
        }

        

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "INSERT INTO projektihenkilot(henkilo_id, projekti_id)" + 
                    "VALUES('"+ this.tbHenkilot.Text + "','" + this.tbProjektit.Text + "');";

                MySqlConnection myCon = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader reader;
                myCon.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Henkilö lisätty projektiin");
                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbHenkilot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "SELECT * FROM henkilotiedot WHERE sukunimi='" + cbHenkilot.Text + "'";

                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string s = myReader.GetInt32("ID").ToString();
                    tbHenkilot.Text = s;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbProjektit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "SELECT * FROM projektitiedot WHERE projekti_nimi='" + cbProjektit.Text + "'";

                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string s = myReader.GetInt32("ID").ToString();
                    tbProjektit.Text = s;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tarkasteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
