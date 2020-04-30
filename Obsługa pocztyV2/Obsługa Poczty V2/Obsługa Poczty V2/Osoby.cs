using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class Osoby : Form
    {
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private Nadawcza wysłane_Odebrane = null;
        private Odbiorcza książka = null;
        private readonly StringComparison comparison = StringComparison.OrdinalIgnoreCase;
        private DataGridViewRow row = null;
        private int index = 0;
        public Osoby()
        {
            InitializeComponent();
            Shown += delegate { dataGridViewOsoby3.ClearSelection(); };
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

        public void OsobyStart(Nadawcza _wysłane_Odebrane, Odbiorcza _książka)
        {
            wysłane_Odebrane = _wysłane_Odebrane;
            książka = _książka;
        }

        private void książkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            książka.DesktopLocation = Location;
            książka.Size = Size;
            książka.Show();
        }

        private void wysłaneOdebraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            wysłane_Odebrane.DesktopLocation = Location;
            wysłane_Odebrane.Size = Size;
            wysłane_Odebrane.Show();
        }

        private void Osoby_FormClosed(object sender, FormClosedEventArgs e)
        {
            wysłane_Odebrane.Close();
        }

        private void Osoby_Load(object sender, EventArgs e)
        {
            Location = wysłane_Odebrane.DesktopLocation;
            Size = wysłane_Odebrane.Size;
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
                    dataGridViewOsoby3.DataSource = table;
                }
                conn.Close();
            }
        }

        private void szukaj(string text, int number)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewOsoby3.DataSource];

            for (int i = 0; i < dataGridViewOsoby3.RowCount; i++)
            {
                string content = dataGridViewOsoby3.Rows[i].Cells[number].Value.ToString();
                currencyManager.SuspendBinding();
                if (content.Contains(text, comparison))
                {
                    dataGridViewOsoby3.Rows[i].Visible = true;
                }
                else
                {
                    dataGridViewOsoby3.Rows[i].Visible = false;
                }
                currencyManager.ResumeBinding();
            }
        }
        private void dataGridViewOsoby3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dataGridViewOsoby3.Rows[e.RowIndex];
                index = int.Parse(row.Cells[0].Value.ToString());
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxTown.Text = row.Cells[2].Value.ToString();
                textBoxStreet.Text = row.Cells[3].Value.ToString();
                textBoxHouseNumber1.Text = row.Cells[4].Value.ToString();
                textBoxHouseNumber2.Text = row.Cells[5].Value.ToString();
                textBoxPostCode.Text = row.Cells[6].Value.ToString();
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxTown.Clear();
            textBoxStreet.Clear();
            textBoxHouseNumber1.Clear();
            textBoxHouseNumber2.Clear();
            textBoxPostCode.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Osoby] ([Imię Nazwisko | Nazwa firmy], [Miasto], [Ulica], [Numer domu], [Numer lokalu], [Kod pocztowy]) VALUES (@Nazwa, @Miasto, @Ulica, @Numer1, @Numer2, @Kod)";

            using (SqlConnection con = connectionBaza())
            {
                try
                {
                    con.Open();
                }
                catch (System.Data.SqlClient.SqlException e2)
                {
                    MessageBox.Show(e2.Message);
                    return;
                }
                SqlCommand queryString = new SqlCommand(query, con);
                queryString.Parameters.Add(new SqlParameter("@Nazwa", textBoxName.Text));
                queryString.Parameters.Add(new SqlParameter("@Miasto", textBoxTown.Text));
                queryString.Parameters.Add(new SqlParameter("@Ulica", textBoxStreet.Text));
                queryString.Parameters.Add(new SqlParameter("@Numer1", textBoxHouseNumber1.Text));
                queryString.Parameters.Add(new SqlParameter("@Numer2", textBoxHouseNumber2.Text));
                queryString.Parameters.Add(new SqlParameter("@Kod", textBoxPostCode.Text));
                queryString.ExecuteNonQuery();
                con.Close();
            }
            GetData();
            row = dataGridViewOsoby3.Rows[dataGridViewOsoby3.Rows.Count - 1];
            index = int.Parse(row.Cells[0].Value.ToString());
            dataGridViewOsoby3.Rows[dataGridViewOsoby3.Rows.Count - 1].Selected = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string query = "UPDATE Osoby SET Nazwa = @Nazwa, ";
                string query4 = "Adres = @Adres WHERE Id = " + index;
                string queerytest = query + query4;
                using (SqlConnection con = connectionBaza())
                {
                    con.Open();
                    SqlCommand queryString = new SqlCommand(queerytest, con);
                    queryString.Parameters.Add(new SqlParameter("@Nazwa", textBoxName.Text));
                    //queryString.Parameters.Add(new SqlParameter("@Adres", textBoxAdress.Text));
                    queryString.ExecuteNonQuery();
                    GetData();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                using (SqlConnection con = connectionBaza())
                {
                    con.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Osoby WHERE Id = " + index, con))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        GetData();
                        dataGridViewOsoby3.ClearSelection();
                    }
                    con.Close();
                }
                row = null;
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }
        }

        private void textBoxName2_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxName2.Text, 1);
        }

        private void textBoxTown2_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxTown.Text, 2);
        }

        private void textBoxStreet2_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxStreet2.Text, 3);
        }

        private void textBoxHouseNumber12_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxHouseNumber12.Text, 4);
        }

        private void textBoxHouseNumber22_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxHouseNumber22.Text, 5);
        }

        private void textBoxPostCode2_TextChanged(object sender, EventArgs e)
        {
            szukaj(textBoxPostCode2.Text, 6);
        }
    }
}
