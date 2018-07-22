using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crime_ms
{
    public partial class Form3 : Form
    {
        int cid =0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");  
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into criminal_info(c_id,cname,cnickname,cgendor,ccontact ,ccrime,cage,ccnic,ccity,caddress) values('"+ textBox3.Text + "','" + textBox2.Text + "','" + textBox10.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox1.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA SUCCESSFULLY ENTERED");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
               

           con.Open();
            SqlCommand  command = new SqlCommand ("select count(c_id) from criminal_info",con);
            SqlDataReader dr = command.ExecuteReader();
            if
               (dr.Read())
            {
                cid = Convert.ToInt32(dr[0]);
                cid++;

            }
            con.Close();
            this.textBox3.Text = "00" + cid.ToString();
          

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }
    }
}
