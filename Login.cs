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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            con.Open();
            string search = "Select * from Login where Username='" + tbusername.Text + "'";
            SqlCommand com = new SqlCommand(search, con);
            com.ExecuteNonQuery();
            SqlDataReader dr;
            dr = com.ExecuteReader();
          
            if (dr.Read())
            {
                String Username = dr["Username"].ToString();
                String password = dr["Password"].ToString();
               
                if (tbpassword.Text == password)
                {
                    Menu a = new Menu();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    tbpassword.Text = "";
                }

            }
            else if (tbusername.Text == "")
            {
                MessageBox.Show("Enter the username");
            }
            else if (tbpassword.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                    MessageBox.Show("Account can not be found");
                    tbpassword.Text = "";
                    tbusername.Text="";               
            }
            con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            account register = new account();
            register.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
