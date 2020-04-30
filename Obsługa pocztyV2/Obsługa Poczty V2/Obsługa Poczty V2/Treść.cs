using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class Treść : Form
    {
        private readonly DodawaniePozycji dodawaniePozycji = null;
        private readonly DodawaniePozycji2 dodawaniePozycji2 = null;
        private readonly Dodawanie dodawanie = null;
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private readonly object okno = null;

        public Treść(DodawaniePozycji _dodawaniePozycji, DodawaniePozycji2 _dodawaniePozycji2, Dodawanie _dodawanie, object _okno)
        {
            okno = _okno;
            dodawaniePozycji = _dodawaniePozycji;
            dodawaniePozycji2 = _dodawaniePozycji2;
            dodawanie = _dodawanie;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodawanie.tresc = richTextBox1.Text;
            dodawanie.tresc.Replace("\n", " ");

            if (okno.GetType().Name == "Akcja")
            {
                string query = "INSERT INTO [Nadawcza] ([Nadawca], [Odbiorca], [Treść], [Data]) VALUES (@Nadawca, @Odbiorca, @Treść, @Data)";

                using (SqlConnection con = connectionBaza())
                {
                    con.Open();
                    SqlCommand queryString = new SqlCommand(query, con);
                    queryString.Parameters.Add(new SqlParameter("@Nadawca", dodawanie.nadawca.Cells[1].Value.ToString()));
                    queryString.Parameters.Add(new SqlParameter("@Odbiorca", dodawanie.odbiorca.Cells[1].Value.ToString()));
                    queryString.Parameters.Add(new SqlParameter("@Treść", dodawanie.tresc));
                    queryString.Parameters.Add(new SqlParameter("@Data", System.DateTime.Now.Date));
                    queryString.ExecuteNonQuery();
                    con.Close();
                }

                Nadawcza akcja = new Nadawcza();
                akcja = (Nadawcza)okno;
                akcja.GetData();
            }

            else if (okno.GetType().Name == "Książka")
            {
                string query = "INSERT INTO [Odbiorcza] ([Nadawca], [Odbiorca], [Treść], [Data]) VALUES (@Nadawca, @Odbiorca, @Treść, @Data)";

                using (SqlConnection con = connectionBaza())
                {
                    con.Open();
                    SqlCommand queryString = new SqlCommand(query, con);
                    queryString.Parameters.Add(new SqlParameter("@Nadawca", dodawanie.nadawca.Cells[1].Value.ToString()));
                    queryString.Parameters.Add(new SqlParameter("@Odbiorca", dodawanie.odbiorca.Cells[1].Value.ToString()));
                    queryString.Parameters.Add(new SqlParameter("@Treść", dodawanie.tresc));
                    queryString.Parameters.Add(new SqlParameter("@Data", System.DateTime.Now.Date));
                    queryString.ExecuteNonQuery();
                    con.Close();
                }

                Odbiorcza książka = new Odbiorcza();
                książka = (Odbiorcza)okno;
                książka.GetData();
            }

            dodawaniePozycji.Close();
            dodawaniePozycji2.Close();
            Close();
        }
    }
}
