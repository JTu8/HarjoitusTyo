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
    public partial class TehtavaProjektiin : Form
    {
        public TehtavaProjektiin()
        {
            InitializeComponent();
        }

        public void NaytaTehtavat()
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                MySqlConnection myConn = new MySqlConnection(conn);
                string tQuery = "SELECT * FROM tehtavat";
                myConn.Open();
                MySqlCommand myCommand = new MySqlCommand(tQuery, myConn);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cbTehtavat.Items.Add(myReader.GetString("tehtava_nimi"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NaytaProjektit()
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

        private void TehtavaProjektiin_Load(object sender, EventArgs e)
        {
            NaytaTehtavat();
            NaytaProjektit();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "INSERT INTO projektitehtavat(projekti_id, tehtava_id)" +
                    "VALUES('" + this.tbProjektit.Text + "','" + this.tbTehtavat.Text + "');";

                MySqlConnection myCon = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader reader;
                myCon.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Tehtävä lisätty projektiin");
                while (reader.Read())
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTehtavat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            try
            {
                string query = "SELECT * FROM tehtavat WHERE tehtava_nimi='" + cbTehtavat.Text + "'";

                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string s = myReader.GetInt32("ID").ToString();
                    tbTehtavat.Text = s;
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
    }
}
