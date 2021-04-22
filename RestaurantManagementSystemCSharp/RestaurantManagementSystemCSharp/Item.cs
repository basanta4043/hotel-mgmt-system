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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restDataSet3.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.restDataSet3.item);
            SqlConnection con = new SqlConnection("server = localhost; user id = root; password =; database = ncc");
            con.Open();
            String str = "Select max(id) from item;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = localhost; user id = root; password =; database = ncc");
            con.Open();
            string typ = string.Empty;
            if (radioButton1.Checked)
            {
                typ = "Veg";
            }
            else
            {
                typ = "Non-Veg";
            }
            try
            {
                String str = "Insert into item(name,cate,descr,price,tax,type) values('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + typ + "');";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from item;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Item Data SuccessFully..");
                    using (SqlConnection con1 = new SqlConnection("server = localhost; user id = root; password =; database = ncc"))
                    {
                        String str2 = "Select * from item";
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
                    comboBox1.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = localhost; user id = root; password =; database = ncc");
            con.Open();
            try
            {
                string getcust = "Select name,cate,descr,price,tax,type from item where id='" + Convert.ToInt32(textBox1.Text) + "';";
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    comboBox1.Text = dr.GetValue(1).ToString();
                    textBox3.Text = dr.GetValue(2).ToString();
                    textBox4.Text = dr.GetValue(3).ToString();
                    textBox5.Text = dr.GetValue(4).ToString();
                    if (dr["type"].ToString() == "Veg")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Item Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = localhost; user id = root; password =; database = ncc");
            con.Open();
            string typ1 = string.Empty;
            if (radioButton1.Checked)
            {
                typ1 = "Veg";
            }
            else
            {
                typ1 = "Non-Veg";
            }
            try
            {
                string getcust = "update item set name='" + textBox2.Text + "',cate='" + comboBox1.Text + "',descr='" + textBox3.Text + "',price='" + textBox4.Text + "',tax='" + textBox5.Text + "',type='" + typ1 + "' where id='" + textBox1.Text + "'; ";
                SqlCommand cmd = new SqlCommand(getcust, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(ID) from item;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Item Data Updated Successfully.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "";
                    using (SqlConnection con1 = new SqlConnection("server = localhost; user id = root; password =; database = ncc"))
                    {
                        String str2 = "Select * from item";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Item Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = localhost; user id = root; password =; database = ncc");
            con.Open();
            try
            {
                string str = "delete from item where id='" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Record Deleted Successfully.");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                using (con)
                {
                    String str2 = "Select * from item";
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
