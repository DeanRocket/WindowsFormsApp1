using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1._1.Connected
{
    public partial class FrmOverFlow : Form
    {
        public FrmOverFlow()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("select * from Products", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                string s = "";

                while (dataReader.Read())
                {
                    s = $"{dataReader["ProductName"],-40}  單價為{dataReader["unitPrice"]:c}";


                    listBox1.Items.Add(s);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from products", conn);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from products Where unitprice >30", conn);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(nwDataSet11.Products);
            this.dataGridView2.DataSource = nwDataSet11.Products;
        }
    }
}
