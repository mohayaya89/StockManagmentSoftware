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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clear_btn(object sender, EventArgs e)
        {
            UserName_txt.Text = "";
            Password_txt.Clear();
            UserName_txt.Focus();
        }

        private void Login_btn(object sender, EventArgs e)
        {
            //TO-DO: Check login username & password
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I42GSN2\\MOHAMMADSQL;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT *
            FROM[dbo].[Login] Where UserName = '"+ UserName_txt.Text +"' and Password = '"+ Password_txt.Text +"'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_btn(sender, e );
            }

        }
    }
}
