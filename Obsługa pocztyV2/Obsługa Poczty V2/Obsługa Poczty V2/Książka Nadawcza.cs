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
    public partial class Nadawcza : Form
    {
        //StringComparison comparison = StringComparison.OrdinalIgnoreCase;
        readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        Odbiorcza książka = new Odbiorcza();
        Osoby osoby = new Osoby();
        public Nadawcza()
        {
            InitializeComponent();
            książka.KsiążkaStart(this, osoby);
            osoby.OsobyStart(this, książka);
            GetData();
        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            osoby.DesktopLocation = this.Location;
            osoby.Size = this.Size;
            osoby.Show();
        }

        private void książkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            książka.DesktopLocation = this.Location;
            książka.Size = this.Size;
            książka.Show();
        }
        public void GetData()
        {
            using (var conn = connectionBaza())
            {
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Nadawcza", conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewOsoby.DataSource = table;
                }
                conn.Close();
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DodawaniePozycji dodawaniePozycji = new DodawaniePozycji(this);
            dodawaniePozycji.Show();
        }

        //private void textBoxNameS_TextChanged(object sender, EventArgs e)
        //{
        //    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewOsoby.DataSource];

        //    for (int i = 0; i < dataGridViewOsoby.RowCount; i++)
        //    {
        //        string content = dataGridViewOsoby.Rows[i].Cells[1].Value.ToString();
        //        currencyManager.SuspendBinding();
        //        if (content.Contains(textBoxNameS.Text, comparison))
        //        {
        //            dataGridViewOsoby.Rows[i].Visible= true;
        //        }
        //        else
        //        {
        //            dataGridViewOsoby.Rows[i].Visible = false;
        //        }
        //        currencyManager.ResumeBinding();
        //    }
        //}
    }
}
