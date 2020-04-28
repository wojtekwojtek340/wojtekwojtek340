using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class Odbiorcza : Form
    {
        readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        Nadawcza wysłane_Odebrane = null;
        Osoby osoby = null;
        public Odbiorcza()
        {            
            InitializeComponent();
            try
            {
                GetData();
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void KsiążkaStart(Nadawcza _wysłane_Odebrane, Osoby _osoby)
        {
            wysłane_Odebrane = _wysłane_Odebrane;
            osoby = _osoby;
        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            osoby.DesktopLocation = this.Location;
            osoby.Size = this.Size;
            osoby.Show();
        }

        private void wysłaneOdebraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            wysłane_Odebrane.DesktopLocation = this.Location;
            wysłane_Odebrane.Size = this.Size;
            wysłane_Odebrane.Show();
        }

        private void Książka_FormClosed(object sender, FormClosedEventArgs e)
        {
            wysłane_Odebrane.Close();
        }

        private void Książka_Load(object sender, EventArgs e)
        {
            this.Location = wysłane_Odebrane.DesktopLocation;
            this.Size = wysłane_Odebrane.Size;
        }
        public void GetData()
        {
            using (var conn = connectionBaza())
            {
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Odbiorcza", conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewOsoby3.DataSource = table;
                }
                conn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DodawaniePozycji dodawaniePozycji = new DodawaniePozycji(this);
            dodawaniePozycji.Show();
        }
    }
}
