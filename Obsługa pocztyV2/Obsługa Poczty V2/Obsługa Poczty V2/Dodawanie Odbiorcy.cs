using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class DodawaniePozycji2 : Form
    {
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private readonly DodawaniePozycji dodawaniePozycji = null;
        private readonly Dodawanie dodawanie = null;
        private readonly object okno = null;
        public DodawaniePozycji2(DodawaniePozycji _dodawaniePozycji, Dodawanie _dodawanie, object _okno)
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
                dataGridViewOsoby.DataSource = table;
            }
            dodawaniePozycji = _dodawaniePozycji;
            dodawanie = _dodawanie;
            okno = _okno;
        }

        private void DodawaniePozycji2_Load(object sender, EventArgs e)
        {
            Location = dodawaniePozycji.DesktopLocation;
            Size = dodawaniePozycji.Size;
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
            if (dodawanie.odbiorca != null)
            {
                Treść treść = new Treść(dodawaniePozycji, this, dodawanie, okno);
                treść.Show();
                Hide();
            }
            else
            {
                if (dataGridViewOsoby.Rows.Count != 0)
                {
                    dodawanie.odbiorca = dataGridViewOsoby.Rows[0];
                    Treść treść = new Treść(dodawaniePozycji, this, dodawanie, okno);
                    treść.Show();
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
                dodawanie.odbiorca = dataGridViewOsoby.Rows[e.RowIndex];
            }
        }

        private void DodawaniePozycji2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dodawaniePozycji != null)
            {
                dodawaniePozycji.Close();
            }
        }
    }
}
