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
    public partial class Form6 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");
        int compid = 0;
        
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select count(compid) from complaint",con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                compid = Convert.ToInt32(dr[0]); 
                compid++;
            }

            this.textBox8.Text  = "00" + compid.ToString();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comand = new SqlCommand("insert into complaint (compid,crname,cremail,crcomplain,croccupation,crcontact,crgendor,craddress,culpritname,culpritgendor,culpritaddress) values ('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox6.Text + "','" + textBox11.Text + "','" + textBox7.Text + "')", con);
            SqlDataAdapter sad = new SqlDataAdapter(comand);
            sad.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA SUCCESSFULLY ENTERED");

            con.Close();
        }
    }
}
