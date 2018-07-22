using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crime_ms
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");

        int rid = 0;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Width = 676;

            //fir id in report
            con.Open();

            SqlCommand command = new SqlCommand("select f_fir_id from fir",con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["f_fir_id"].ToString());
             }


            con.Close();

            //report id 
         /*   con.Open();
            SqlCommand command1 = new SqlCommand("select count(r_id) from report",con);
            SqlDataReader dr3 = command1.ExecuteReader();
            if (dr3.Read())
            {
                rid = Convert.ToInt32(dr3[0]);
                rid++;

            }

            con.Close();
            this.textBox12.Text = "00" + rid.ToString();*/

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox11.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Please Fill all Field Correctly");
            }
                
            this.Width = 908;

            con.Open();

            string query = "insert into report(r_fir_id,rcase,rcriminalname, rinvestofficer,rname, rage, rcontact,rcnic, rgendor, rpunishment, raddress)values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox11.Text + "','" + textBox8.Text + "','" + textBox3.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("DATA SUCCESSFULLY ENTERED");
            con.Close();
          
            this.textBox10.Text +=  Environment.NewLine + Environment.NewLine + Environment.NewLine + " FIR ID = " + this.comboBox1.Text + Environment.NewLine + Environment.NewLine + " CRIMINAL NAME = " + this.textBox7.Text + Environment.NewLine + Environment.NewLine + " CASE = " + this.textBox9.Text + Environment.NewLine + Environment.NewLine + " CASE HANDLER  = " + this.textBox1.Text + Environment.NewLine + Environment.NewLine + "                x-x-x-x-x-x-x-x ";

        
        
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

                SqlCommand cmd = new SqlCommand ("select * from fir where f_fir_id ='"+comboBox1.Text+"'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    textBox7.Text = dr["fcriminalname"].ToString();
                    textBox1.Text = dr["finvestofficer"].ToString();
                    textBox9.Text = dr["fcase"].ToString();
            
                }
             con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
