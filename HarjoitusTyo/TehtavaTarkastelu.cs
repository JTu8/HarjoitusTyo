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
    public partial class TehtavaTarkastelu : Form
    {

        TehtavaLisays parent = null;

        public TehtavaTarkastelu(TehtavaLisays parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnNayta_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            string query = "SELECT * FROM tehtavat";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgShowTehtavat.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand command = new MySqlCommand();
                conn.Open();
                for (int i = 0; i < dgShowTehtavat.Rows.Count; i++)
                {
                    DataGridViewRow delRow = dgShowTehtavat.Rows[i];
                    if (delRow.Selected == true)
                    {
                        dgShowTehtavat.Rows.RemoveAt(i);
                        try
                        {
                            command.CommandText = "DELETE FROM tehtavat WHERE ID=" + i + "";
                            command.Connection = conn;
                            int count = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
        }

        private void dgShowTehtavat_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            string connString = "Server=localhost;Database=harjoitustyo;UID=root;Password=''";

            string query = "SELECT * FROM tehtavat";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable muutos = ((DataTable)dgShowTehtavat.DataSource).GetChanges();

                    if (muutos != null)
                    {
                        MySqlCommandBuilder myBuilder = new MySqlCommandBuilder(adapter);
                        adapter.UpdateCommand = myBuilder.GetUpdateCommand();
                        adapter.Update(muutos);
                        ((DataTable)dgShowTehtavat.DataSource).AcceptChanges();
                    }
                }
            }
        }

        private void ohjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klikkaa näytä, niin saat tehtävät näkyviin\nJos haluat muokata, niin valitse muokattava " +
                "rivi ja kirjoita muutos siihen. Tämän jälkeen paina enteriä\nJos haluat poistaa, valitse poistettava " +
                "rivi ja klikkaa poista nappia");
        }
    }
}
