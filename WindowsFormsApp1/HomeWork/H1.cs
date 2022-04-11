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

namespace WindowsFormsApp1.HomeWork
{
    public partial class H1 : Form
    {
        public H1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Beverages")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 1 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }

            if (comboBox1.Text == "Condiments")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 2 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            if (comboBox1.Text == "Confections")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 3 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            if (comboBox1.Text == "Dairy Products")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 4 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            if (comboBox1.Text == "Grains/Cereals")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 5 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            if (comboBox1.Text == "Meat/Poultry")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 6 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            if (comboBox1.Text == "Produce")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 7 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            if (comboBox1.Text == "Seafood")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select productid,productname,[products].categoryid,categoryname,unitprice,picture from [products] join Categories on [products].categoryid = categories.categoryid where [products].Categoryid = 8 ", conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }

        }
    }
}
