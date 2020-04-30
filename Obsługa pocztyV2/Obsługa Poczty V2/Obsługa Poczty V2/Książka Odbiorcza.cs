using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class Odbiorcza : Form
    {
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private Nadawcza wysłane_Odebrane = null;
        private Osoby osoby = null;
        public Odbiorcza()
        {
            InitializeComponent();
            try
            {
                GetData();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
                DataTable table = new DataTable();
                dataGridViewOsoby3.DataSource = table;
            }
        }

        public void KsiążkaStart(Nadawcza _wysłane_Odebrane, Osoby _osoby)
        {
            wysłane_Odebrane = _wysłane_Odebrane;
            osoby = _osoby;
        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            osoby.DesktopLocation = Location;
            osoby.Size = Size;
            osoby.Show();
        }

        private void wysłaneOdebraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            wysłane_Odebrane.DesktopLocation = Location;
            wysłane_Odebrane.Size = Size;
            wysłane_Odebrane.Show();
        }

        private void Książka_FormClosed(object sender, FormClosedEventArgs e)
        {
            wysłane_Odebrane.Close();
        }

        private void Książka_Load(object sender, EventArgs e)
        {
            Location = wysłane_Odebrane.DesktopLocation;
            Size = wysłane_Odebrane.Size;
        }
        public void GetData()
        {
            using (SqlConnection conn = connectionBaza())
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
            DodawaniePozycji dodawaniePozycji = null;
            try
            {
                dodawaniePozycji = new DodawaniePozycji(this);
            }
            catch (System.Data.SqlClient.SqlException e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }
            dodawaniePozycji.Show();
        }
    }
}
