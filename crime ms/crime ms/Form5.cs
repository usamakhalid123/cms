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
    public partial class Form5 : Form
    {

        int fid = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");  
 
        
        
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Width = 681;



            con.Open();
            SqlCommand command = new SqlCommand("select  count(f_fir_id) from fir ",con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                fid = Convert.ToInt32(dr[0]);
                fid++;

            }

           con.Close();
           this.textBox8.Text = "00" + fid.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            if (textBox1.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Please Fill all Field Correctly");
                
            }

            this.Width = 945;
        con.Open();
        SqlCommand command = new SqlCommand("insert into fir ( f_fir_id, fcriminalname,fcase,finvestofficer,fpersonname,fpcontact,fpgendor,fpaddress,fvvictimname,fvage,fvgendor,fvaddress) values ('" + textBox8.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox13.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox10.Text + "','"+ textBox12.Text + "','" + textBox2.Text + "')", con);
        SqlDataAdapter sad = new SqlDataAdapter(command);
        sad.SelectCommand.ExecuteNonQuery();
        con.Close();
        MessageBox.Show("DATA SUCCESSFULLY ENTERED");


            con.Close();

            this.textBox6.Text +=  Environment.NewLine + Environment.NewLine +Environment.NewLine+ " FIR ID = " + this.textBox8.Text + Environment.NewLine +Environment.NewLine + " CRIMINAL NAME = " + this.textBox7.Text +Environment.NewLine +Environment.NewLine+ " CASE = " + this.textBox9.Text +Environment.NewLine +Environment.NewLine+ " CASE HANDLER  = " +this.textBox1.Text+Environment.NewLine+Environment.NewLine+"                x-x-x-x-x-x-x-x ";



        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
