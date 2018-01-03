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
    public partial class ProjektiTarkastelu : Form
    {

        ProjektiLisays parent = null;

        public ProjektiTarkastelu(ProjektiLisays parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnNayta_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            string query = "SELECT * FROM projektitiedot";
            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgShowProjektit.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand command = new MySqlCommand();
                conn.Open();
                for (int i = 0; i < dgShowProjektit.Rows.Count; i++)
                {
                    DataGridViewRow delRow = dgShowProjektit.Rows[i];
                    if (delRow.Selected == true)
                    {
                        dgShowProjektit.Rows.RemoveAt(i);
                        try
                        {
                            command.CommandText = "DELETE FROM projektitiedot WHERE ID=" + i + "";
                            command.Connection = conn;
                            int count = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void dgShowProjektit_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            string query = "SELECT * FROM projektitiedot";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable muutos = ((DataTable)dgShowProjektit.DataSource).GetChanges();

                    if (muutos != null)
                    {
                        MySqlCommandBuilder myBuilder = new MySqlCommandBuilder(adapter);
                        adapter.UpdateCommand = myBuilder.GetUpdateCommand();
                        adapter.Update(muutos);
                        ((DataTable)dgShowProjektit.DataSource).AcceptChanges();
                    }
                }
            }
        }

        private void ohjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klikkaa näytä, niin saat projektit näkyviin\nJos haluat muokata, niin valitse muokattava " + 
                "rivi ja kirjoita muutos siihen. Tämän jälkeen paina enteriä\nJos haluat poistaa, valitse poistettava " + 
                "rivi ja klikkaa poista nappia");
        }
    }
}
