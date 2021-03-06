﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Obsługa_Poczty_V2
{
    public partial class Nadawcza : Form
    {
        //StringComparison comparison = StringComparison.OrdinalIgnoreCase;
        private readonly Func<SqlConnection> connectionBaza = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
        private readonly Odbiorcza książka = new Odbiorcza();
        private readonly Osoby osoby = new Osoby();
        public DataGridViewRow row = null;
        public int index;
        public Nadawcza()
        {
            InitializeComponent();
            Shown += delegate { dataGridViewOsoby.ClearSelection(); };
            książka.KsiążkaStart(this, osoby);
            osoby.OsobyStart(this, książka);
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
        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            osoby.DesktopLocation = Location;
            osoby.Size = Size;
            osoby.Show();
        }

        private void książkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            książka.DesktopLocation = Location;
            książka.Size = Size;
            książka.Show();
        }
        public void GetData()
        {
            using (SqlConnection conn = connectionBaza())
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                using (SqlConnection con = connectionBaza())
                {
                    con.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Nadawcza WHERE Id = " + index, con))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        GetData();
                    }
                    con.Close();
                    dataGridViewOsoby.ClearSelection();
                }
                row = null;
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }
        }

        private void dataGridViewOsoby_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dataGridViewOsoby.Rows[e.RowIndex];
                index = int.Parse(row.Cells[0].Value.ToString());
            }
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
