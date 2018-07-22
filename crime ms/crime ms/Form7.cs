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
    public partial class Form7 : Form
    {
        int cid = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");  
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from fir where f_fir_id='" + comboBox1.Text + "'";
            SqlDataAdapter sdaa = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sdaa.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from fir where f_fir_id ='" + comboBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr["fcriminalname"].ToString();
                textBox1.Text = dr["fcase"].ToString();
            }


            con.Close();
           

        }

        private void Form7_Load(object sender, EventArgs e)
        {
           //crimnal search
            con.Open();

            SqlCommand cmd = new SqlCommand("select c_id from criminal_info",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["c_id"].ToString());
            }


            con.Close();

            //Fir Search
            con.Open();

            SqlCommand command = new SqlCommand("select f_fir_id from fir", con);
            SqlDataReader dr1 = command.ExecuteReader();
          while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["f_fir_id"].ToString());
             
            }
            
            con.Close();

            //report search

            con.Open();

            SqlCommand comd = new SqlCommand("select r_fir_id from report",con);
            SqlDataReader dr2 = comd.ExecuteReader();
            while (dr2.Read())
            {
                this.comboBox2.Items.Add(dr2["r_fir_id"].ToString());
            
            }
        
            con.Close();

            //complaint search
            con.Open();
            SqlCommand cd = new SqlCommand("select compid from complaint",con);
            SqlDataReader drr = cd.ExecuteReader();
            while ( drr.Read())
            {

                this.comboBox4.Items.Add(drr["compid"].ToString());
            }



            con.Close();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from criminal_info where c_id='" + comboBox3.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from criminal_info where c_id ='" + comboBox3.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox5.Text = dr["cname"].ToString();
                textBox6.Text = dr["cnickname"].ToString();
            }


            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from report where r_fir_id = '"+comboBox2.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                textBox3.Text = dr["rcriminalname"].ToString();
                textBox4.Text = dr["rcase"].ToString();
            }
            con.Close();

            con.Open();
            SqlCommand command = new SqlCommand("select * from report where r_fir_id = '"+ comboBox2.Text+"'",con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);
            dataGridView2.DataSource = dtt;
            con.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cdd = new SqlCommand("select * from complaint where compid ='" +comboBox4.Text+"'",con);
            SqlDataAdapter ssda = new SqlDataAdapter(cdd);
            DataTable dtt = new DataTable();
            ssda.Fill(dtt);
            dataGridView4.DataSource = dtt;

            con.Close();


            con.Open();
            SqlCommand ssd = new SqlCommand ("select * from complaint where compid = '"+comboBox4.Text+"'",con);
            SqlDataReader sdr = ssd.ExecuteReader();
            if (sdr.Read())
            {

                textBox7.Text = sdr["crname"].ToString();
                textBox8.Text = sdr["craddress"].ToString();
            }


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand command = new SqlCommand("delete from fir where f_fir_id='"+comboBox5.Text+"'");
            SqlDataReader ddr = command.ExecuteNonQuery();
            MessageBox.Show("SUCCESSFULLY DONE");
            con.Close();*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
