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
    public partial class DodawaniePozycji2 : Form
    {
        readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        DodawaniePozycji dodawaniePozycji = null;
        Dodawanie dodawanie = null;
        System.Object okno = null;
        public DodawaniePozycji2(DodawaniePozycji _dodawaniePozycji, Dodawanie _dodawanie, System.Object _okno)
        {
            InitializeComponent();
            GetData();            
            dodawaniePozycji = _dodawaniePozycji;
            dodawanie = _dodawanie;
            okno = _okno;
        }

        private void DodawaniePozycji2_Load(object sender, EventArgs e)
        {
            this.Location = dodawaniePozycji.DesktopLocation;
            this.Size = dodawaniePozycji.Size;
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
            if (dodawanie.odbiorca != null)
            {
                Treść treść = new Treść(dodawaniePozycji, this, dodawanie, okno);
                treść.Show();
                this.Hide();
            }
            else
            {
                if (dataGridViewOsoby.Rows.Count != 0)
                {
                    dodawanie.odbiorca = dataGridViewOsoby.Rows[0];
                    Treść treść = new Treść(dodawaniePozycji, this, dodawanie, okno);
                    treść.Show();
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
                dodawanie.odbiorca = dataGridViewOsoby.Rows[e.RowIndex];
            }
        }
    }
}
