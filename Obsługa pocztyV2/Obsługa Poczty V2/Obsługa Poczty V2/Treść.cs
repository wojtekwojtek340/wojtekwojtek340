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
    public partial class Treść : Form
    {
        DodawaniePozycji dodawaniePozycji = null;
        DodawaniePozycji2 dodawaniePozycji2 = null;
        Dodawanie dodawanie = null;
        readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        System.Object okno = null;

        public Treść(DodawaniePozycji _dodawaniePozycji, DodawaniePozycji2 _dodawaniePozycji2, Dodawanie _dodawanie, System.Object _okno)
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

                using (var con = connectionBaza())
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

            else if(okno.GetType().Name == "Książka")
            {
                string query = "INSERT INTO [Odbiorcza] ([Nadawca], [Odbiorca], [Treść], [Data]) VALUES (@Nadawca, @Odbiorca, @Treść, @Data)";

                using (var con = connectionBaza())
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
            this.Close();
        }
    }
}
