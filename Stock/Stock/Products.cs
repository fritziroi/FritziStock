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
            cmbStatus.SelectedIndex = 0;
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StockDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            bool status = false;
            if (cmbStatus.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            var sqlQuery = "";
            if (IfProductExisist(con,txtProductCode.Text))
            {
                sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + txtProductName.Text + "', [ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + txtProductCode.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [StockDB].[dbo].[Products]([ProductCode],[ProductName],[ProductStatus])
                               VALUES
                                    ('" + txtProductCode.Text + "','" + txtProductName.Text + "','" + status + "') ";
            }
            SqlCommand cmd = new SqlCommand(sqlQuery ,con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            ClearFilds();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProductCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()=="פעיל")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }
            btnAdd.Text = "עדכן";
        }

        private bool IfProductExisist(SqlConnection con,string productcode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [StockDB].[dbo].[Products] WHERE [ProductCode] = '"+ productcode +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StockDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [StockDB].[dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "פעיל";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "לא פעיל";
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StockDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            var sqlQuery = "";
            if (IfProductExisist(con, txtProductCode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + txtProductCode.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("!... מוצר לא קיים");
            }
            LoadData();
            ClearFilds();
        }

        private void ClearFilds()
        {
            txtProductName.Text = "";
            txtProductCode.Text = "";
            btnAdd.Text = "הוסף";
        }
    }
}
