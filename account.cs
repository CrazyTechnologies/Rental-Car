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

namespace Ayubo_Drive
{
    public partial class account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            tbusername.Enabled = false;
            tbpassword.Enabled = false;
            btncreate.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginpage = new Login();
            loginpage.Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
             if (tbusername.Text=="")
            {
                MessageBox.Show("Enter username is must");
            }
            else if (tbpassword.Text == "")
            {
                MessageBox.Show("Enter password is must");
            }
            else
            {
                con.Open();
                int staff_id = Convert.ToInt32(tbstaffid.Text);
                string username = tbusername.Text;
                string password = tbpassword.Text;
                string insert = "Insert into Login (Staff_ID,Password,Username)Values('" + tbstaffid.Text + "','" + tbpassword.Text + "','" + tbusername.Text + "')";
                SqlCommand com = new SqlCommand(insert, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record successfully saved");
                tbpassword.Text = "";
                tbstaffid.Text = "";
                tbusername.Text = "";
                tbusername.Enabled = false;
                tbpassword.Enabled = false;
                tbstaffid.Enabled = true;
                btncreate.Enabled = false;
                con.Close();
            }      
        }

        private void tbstaffid_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (tbstaffid.Text == "")
            {
                MessageBox.Show("Enter a staff id");
            }
            else
            {
                con.Open();

                int staff_id = Convert.ToInt32(tbstaffid.Text);
                string sqlserach = "Select * from Login where Staff_ID='" + tbstaffid.Text + "'";
                SqlCommand com = new SqlCommand(sqlserach, con);
                com.ExecuteNonQuery();
                SqlDataReader dr;
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Record already exists", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbstaffid.Text = "";
                }
                else
                {
                    tbpassword.Enabled = true;
                    tbusername.Enabled = true;
                    tbstaffid.Enabled = false;
                    btncreate.Enabled = true;
                }
                con.Close();
            }

        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Show.Checked == true)
            {
                tbpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
