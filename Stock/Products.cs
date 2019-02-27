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

namespace Stock
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Status_ComboBox.SelectedIndex = 0;
            LoadData();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I42GSN2\\MOHAMMADSQL;Initial Catalog=Stock;Integrated Security=True");
            // Insert Logic
            connection.Open();
            bool status = false;
            if (Status_ComboBox.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = "";
            if (IfProductExist(connection, ProductCode_txt.Text))
            {
                sqlQuery = @"UPDATE [dbo].[Products]
                            SET [ProductName] = '" + ProductName_txt.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + ProductCode_txt.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [dbo].[Products] ([ProductCode] ,[ProductName] ,[ProductStatus])
                           VALUES ('" + ProductCode_txt.Text + "','" + ProductName_txt.Text + "','" + status + "')";
            }

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            // Reading Data
            LoadData();
        }

        private bool IfProductExist(SqlConnection connection, string productCode)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select 1 From [dbo].[Products] WHERE [ProductCode] = '" + productCode + "'", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I42GSN2\\MOHAMMADSQL;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From [dbo].[Products]", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductCode_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProductName_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                Status_ComboBox.SelectedIndex = 0;
            }
            else
            {
                Status_ComboBox.SelectedIndex = 1;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I42GSN2\\MOHAMMADSQL;Initial Catalog=Stock;Integrated Security=True");

            var sqlQuery = "";
            if (IfProductExist(connection, ProductCode_txt.Text))
            {
                connection.Open();
                sqlQuery = @"DELETE FROM [dbo].[Products]
                            WHERE [ProductCode] = '" + ProductCode_txt.Text + "'";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Record Not Exist....!");
            }

            // Reading Data
            LoadData();
        }
    }
}
