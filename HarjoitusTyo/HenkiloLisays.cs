using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HarjoitusTyo
{
    public partial class HenkiloLisays : Form
    {

        Aloitus parent = null;
        public string etunimi;
        public string sukunimi;
        public string email;
        public string osoite;
        public string postinro;
        public string postitoimipaikka;

        public HenkiloLisays(Aloitus parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
           // DBConnect c = new DBConnect();
            //string connectionString = null;
            string conn = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";
            MySqlConnection con = new MySqlConnection(conn);

            try
            {
                
                string query = "INSERT INTO henkilotiedot(etunimi, sukunimi, email, puhnumero, osoite, postinumero, postitoimipaikka)" +
                    "VALUES('" + this.tbEtunimi.Text + "','" + this.tbSukunimi.Text + "','" + this.tbEmail.Text + "','" + this.tbPuhNumero.Text + 
                    "','" + this.tbOsoite.Text + "','" + this.tbPostiNumero.Text + "','" + this.tbPostiToimiPaikka.Text + "');";

                if (tbPostiNumero.Text.Length < 5 || tbPostiNumero.Text.Length > 5)
                {
                    MessageBox.Show("Postinumero liian pitkä tai liian lyhyt");
                }

                //c.Initialize();
                MySqlConnection myCon = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                myCon.Open();
                //c.openConnection();
                myReader = command.ExecuteReader();
                MessageBox.Show("Tiedot tallennettu");
                while (myReader.Read())
                {

                }
                myCon.Close();
                //c.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbEtunimi.Text = String.Empty;
            tbSukunimi.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbPuhNumero.Text = String.Empty;
            tbOsoite.Text = String.Empty;
            tbPostiNumero.Text = String.Empty;
            tbPostiToimiPaikka.Text = String.Empty;
        }

        private void btnTarkastele_Click(object sender, EventArgs e)
        {
            HenkiloTarkastelu h = new HenkiloTarkastelu(this);
            h.Show();
        }

        private void lisääHenkilöProjektiinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HenkiloProjektiin h = new HenkiloProjektiin();
            DialogResult res;
            res = h.ShowDialog();
        }
    }
}
