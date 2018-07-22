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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KBT9A5M;Initial Catalog=crime;Integrated Security=True");
        int cid = 0;
        
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;         
            this.textBox5.Enabled = false;
            this.textBox6.Enabled = false;
            this.textBox7.Enabled = false;
            this.textBox8.Enabled = false;
            this.textBox9.Enabled = false;
            this.textBox10.Enabled = false;
            this.textBox3.Enabled = false;

            con.Open();

            SqlCommand cmd = new SqlCommand("select c_id from criminal_info", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["c_id"].ToString());
            }


            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.textBox5.Enabled = true;
            this.textBox6.Enabled = true;
            this.textBox7.Enabled = true;
            this.textBox8.Enabled = true;
            this.textBox9.Enabled = true;
            this.textBox10.Enabled = true;

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from criminal_info where c_id ='" + comboBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr["cname"].ToString();
                textBox10.Text = dr["cnickname"].ToString();
                textBox3.Text = dr["cgendor"].ToString();
                textBox5.Text = dr["ccontact"].ToString();
                textBox9.Text = dr["ccrime"].ToString();
                textBox7.Text = dr["ccnic"].ToString();
                textBox1.Text = dr["ccity"].ToString();
                textBox8.Text = dr["cage"].ToString();
                textBox6.Text = dr["caddress"].ToString();
           }


            con.Close();

          

        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* con.Open();
            SqlCommand cmd = new SqlCommand("update criminal_info set  cname ='" + textBox2.Text + "' , cnickname = '" + textBox10.Text + "' ,  cgendor = '" + textBox3.Text + "' , ccontact = '" + textBox5.Text + "', ccrime = '" + textBox9.Text + "',  ccnic = '" + textBox7.Text + "',  ccity  = '" + textBox1.Text + "', cage = '" + textBox8.Text + "', caddress = '" + textBox6.Text + "'",con);
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SUCCESSFULLY UPDATED");*/
            con.Open();
            SqlCommand cc = new SqlCommand("update  criminal_info  set cname=@cname,cnickname=@cnickname,cgendor=@cgendor,ccontact=@ccontact,ccrime=@ccrime,ccnic=@ccnic,ccity=@ccity,cage=@cage,caddress=@caddress  where c_id ='" +comboBox1.Text + "'", con);
            cc.Parameters.AddWithValue("@cname ", textBox2.Text);
            cc.Parameters.AddWithValue("@cnickname", textBox10.Text);
            cc.Parameters.AddWithValue("@cgendor", textBox3.Text);
            cc.Parameters.AddWithValue("@ccontact", textBox9.Text);
            cc.Parameters.AddWithValue("@ccrime", textBox9.Text);
            cc.Parameters.AddWithValue("@ccnic", textBox7.Text);
            cc.Parameters.AddWithValue("@cage", textBox8.Text);
            cc.Parameters.AddWithValue("@ccity", textBox1.Text);
            cc.Parameters.AddWithValue("@caddress", textBox6.Text);          
                 
            
            SqlDataAdapter sda = new SqlDataAdapter(cc);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SUCCESSFULLY UPDATED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox8.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.comboBox1.Text="";
            
        
        }
    }
}
