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
    public partial class DodawaniePozycji : Form
    {
        readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        Dodawanie dodawanie = new Dodawanie();
        System.Object okno = null;
        public DodawaniePozycji(System.Object _okno)
        {
            InitializeComponent();
            GetData();
            okno = _okno;
        }
        void GetData()
        {
            using (var conn = connectionBaza())
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
                this.Hide();
            }
            else
            {
                if (dataGridViewOsoby.Rows.Count != 0)
                {
                    dodawanie.nadawca = dataGridViewOsoby.Rows[0];
                    DodawaniePozycji2 dodawaniePozycji2 = new DodawaniePozycji2(this, dodawanie, okno);
                    dodawaniePozycji2.Show();
                    this.Hide();
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
