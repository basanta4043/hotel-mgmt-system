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

namespace RestaurantManagementSystemCSharp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True");
            con.Open();
            try
            {
                String str = "Insert into cust(name,addr,mobi,email,dob) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "');";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from cust;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Customer Data SuccessFully..");
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True"))
                    {
                        String str2 = "Select * from cust";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                   
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restDataSet.cust' table. You can move, or remove it, as needed.
            this.custTableAdapter.Fill(this.restDataSet.cust);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True");
            con.Open();
            String str = "Select max(id) from cust;";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string getcust = "Select name,addr,mobi,email,dob from cust where id='" + Convert.ToInt32(textBox1.Text) + "';";
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    textBox3.Text = dr.GetValue(1).ToString();
                    textBox4.Text = dr.GetValue(2).ToString();
                    textBox5.Text = dr.GetValue(3).ToString();
                    textBox6.Text = dr.GetValue(4).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Customer Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string getcust = "update cust set name='" + textBox2.Text + "',addr='" + textBox3.Text + "',mobi='" + textBox4.Text + "',email='" + textBox5.Text + "',dob='" + textBox6.Text + "' where id='" + textBox1.Text + "'; ";
                SqlCommand cmd = new SqlCommand(getcust, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(ID) from cust;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Customer Data Updated Successfully.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True"))
                    {
                        String str2 = "Select * from cust";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Customer Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\RestaurantManagementSystemCSharp\RestaurantManagementSystemCSharp\rest.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = "delete from cust where id='"+ textBox1.Text +"';";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully.");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
               
                using (con)
                {
                    String str2 = "Select * from cust";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
