using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class DodawaniePozycji : Form
    {
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private readonly Dodawanie dodawanie = new Dodawanie();
        private readonly object okno = null;
        public DodawaniePozycji(object _okno)
        {
            InitializeComponent();
            try
            {
                GetData();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }
            okno = _okno;
        }

        private void GetData()
        {
            using (SqlConnection conn = connectionBaza())
            {
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Osoby", conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewOsoby.DataSource = table;
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dodawanie.nadawca != null)
            {
                DodawaniePozycji2 dodawaniePozycji2 = new DodawaniePozycji2(this, dodawanie, okno);
                dodawaniePozycji2.Show();
                Hide();
            }
            else
            {
                if (dataGridViewOsoby.Rows.Count != 0)
                {
                    dodawanie.nadawca = dataGridViewOsoby.Rows[0];
                    DodawaniePozycji2 dodawaniePozycji2 = new DodawaniePozycji2(this, dodawanie, okno);
                    dodawaniePozycji2.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Proszę dodać pozycję.");
                }

            }
        }

        private void dataGridViewOsoby_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                dodawanie.nadawca = dataGridViewOsoby.Rows[e.RowIndex];
            }

        }
    }
}
