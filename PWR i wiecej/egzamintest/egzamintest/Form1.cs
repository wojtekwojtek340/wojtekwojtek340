using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamintest
{
    public partial class Form1 : Form
    {

        DataGridViewRow row = null;
        string ID;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string connectionString = "Server=DESKTOP-OISLER2\\WOJTEKSQL;Database=NORTHWND;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=DESKTOP-OISLER2\\WOJTEKSQL;Database=NORTHWND;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            string query = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID =" +"'"+ID+"'";

            using(con)
            {
                con.Open();
                SqlCommand queryString = new SqlCommand(query, con);
                queryString.Parameters.Add(new SqlParameter("@CompanyName", "test"));
                queryString.ExecuteNonQuery();
                LoadData();
                con.Close();
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dataGridView1.Rows[e.RowIndex];
                ID = row.Cells["CustomerID"].Value.ToString();
            }
        }
    }
}
