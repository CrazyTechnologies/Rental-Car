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
    public partial class Vehicle : Form
    {
        SqlConnection con=new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public Vehicle()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        public void clear()
        {
            tbvehicle_no.Text = "";
            tbvehicle_type.Text = "";
            tbvehicle_model.Text = "";
            tbrate_per_day.Text = "";
            tbrate_per_week.Text = "";
            tbrate_per_month.Text = "";
            tbdriver_rate.Text = "";
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            tbvehicle_no.Enabled = true;
            btnadd.Enabled = true;
        }
        private void Vehicle_Load(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            btnedit.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();

            string search = "Select * from Vehicles where Veh_No='" + tbvehicle_no.Text+"' ";
            SqlCommand com = new SqlCommand(search, con);
            com.ExecuteNonQuery();
            SqlDataReader dr;
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                string veh_no = dr["Veh_No"].ToString();
                string veh_type = dr["veh_Type"].ToString();
                string veh_model = dr["veh_model"].ToString();
                string per_day = dr["Rate_Per_Day"].ToString();
                string per_week =dr["Rate_Per_week"].ToString();
                string per_month = dr["Rate_Per_month"].ToString();
                string driver_rate = dr["Driver_Rate"].ToString();

                tbvehicle_no.Text = veh_no;
                tbvehicle_type.Text = veh_type;
                tbvehicle_model.Text = veh_model;
                tbrate_per_day.Text = per_day;
                tbrate_per_week.Text = per_week;
                tbrate_per_month.Text = per_month;
                tbdriver_rate.Text = driver_rate;

                tbvehicle_no.Enabled = false;
                btnadd.Enabled = false;
                btndelete.Enabled = true;
                btnedit.Enabled = true;

            }
            else if(tbvehicle_no.Text=="")
            {
                MessageBox.Show("Enter a vehicle number");
            }
            else
            {
                MessageBox.Show("Record not availabe");
                tbvehicle_no.Text = "";
            }
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
                con.Open();

                string veh_no = tbvehicle_no.Text;
                

                string search = "Select * from Vehicles where Veh_No='"+tbvehicle_no.Text+"'";
                SqlCommand com=new SqlCommand(search, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Record already exists");
                tbvehicle_no.Text = "";
                }
                else if (tbvehicle_no.Text == "")
                {
                    MessageBox.Show("Enter vehicle number");
                }
                else if (tbvehicle_type.Text == "")
                {
                    MessageBox.Show("Enter vehicle type");
                }
                else if (tbvehicle_model.Text == "")
                {
                    MessageBox.Show("Enter vehicle model");
                }
                else if (tbrate_per_day.Text == "")
                {
                    MessageBox.Show("Enter per day rate");
                }
                else if (tbrate_per_week.Text == "")
                {
                    MessageBox.Show("Enter per week rate");
                }
                else if (tbrate_per_month.Text == "")
                {
                    MessageBox.Show("Enter per month rate");
                }
                else if (tbdriver_rate.Text == "")
                {
                    MessageBox.Show("Enter driver rate");
                }
                else
                {
                conn.Open();
                
                string veh_type = tbvehicle_type.Text;
                string veh_model = tbvehicle_model.Text;
                double per_day = Convert.ToDouble(tbrate_per_day.Text);
                double per_week = Convert.ToDouble(tbrate_per_week.Text);
                double per_month = Convert.ToDouble(tbrate_per_month.Text);
                double driver_rate = Convert.ToDouble(tbdriver_rate.Text);
               
                string insert = "Insert into Vehicles (Veh_No,veh_Type,veh_model,Rate_Per_Day,Rate_Per_week,Rate_Per_month,Driver_Rate)Values('" + tbvehicle_no.Text+"','"+tbvehicle_type.Text+"','"+tbvehicle_model.Text+"','"+tbrate_per_day.Text+"','"+tbrate_per_week.Text+"','"+tbrate_per_month.Text+"','"+tbdriver_rate.Text+"') ";
                    
                SqlCommand comm=new SqlCommand(insert, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Record successfully saved");                  
                clear();

                conn.Close();
                }
                con.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (tbvehicle_no.Text == "")
            {
                MessageBox.Show("Enter vehicle number");
            }
            else if (tbvehicle_type.Text == "")
            {
                MessageBox.Show("Enter vehicle type");
            }
            else if (tbvehicle_model.Text == "")
            {
                MessageBox.Show("Enter vehicle model");
            }
            else if (tbrate_per_day.Text == "")
            {
                MessageBox.Show("Enter per day rate");
            }
            else if (tbrate_per_week.Text == "")
            {
                MessageBox.Show("Enter per week rate");
            }
            else if (tbrate_per_month.Text == "")
            {
                MessageBox.Show("Enter per month rate");
            }
            else if (tbdriver_rate.Text == "")
            {
                MessageBox.Show("Enter driver rate");
            }
            else
            {
                con.Open();

                string update = "Update Vehicles set veh_Type='" + tbvehicle_type.Text + "',veh_model='"+tbvehicle_model.Text+ "',Rate_Per_Day='"+tbrate_per_day.Text+ "',Rate_Per_week='"+tbrate_per_week.Text+ "',Rate_Per_month='"+tbrate_per_month.Text+"',Driver_Rate='"+tbdriver_rate.Text+ "' where Veh_No='"+tbvehicle_no.Text+"'  ";
                SqlCommand com = new SqlCommand(update, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record succcessfully updated");
                clear();

                con.Close();
            }
         }

        private void btndelete_Click(object sender, EventArgs e)
        {
           

            DialogResult msg = MessageBox.Show("Are you sue ?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == msg)
            {
                con.Open();

                string delete = "Delete from Vehicles where Veh_No='" + tbvehicle_no.Text + "'";
                SqlCommand com = new SqlCommand(delete, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record successfully deleted");
                clear();

                con.Close();
            }
            else { }          
        }
    }
}
