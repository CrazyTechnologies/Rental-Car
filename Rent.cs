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
    public partial class Rent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public Rent()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            tbvehicle_type.Enabled = false;
            tbvehicle_model.Enabled = false;
            tbrate_per_day.Enabled = false;
            tbrate_per_week.Enabled = false;
            tbrate_per_month.Enabled = false;
            tbdriver_rate.Enabled = false;

        }

        private void btnveh_search_Click(object sender, EventArgs e)
        {
            con.Open();

            string search = "Select * from Vehicles where Veh_No='" + tbvehicle_no.Text + "' ";
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
                string per_week = dr["Rate_Per_week"].ToString();
                string per_month = dr["Rate_Per_month"].ToString();
                string driver_rate = dr["Driver_Rate"].ToString();

                tbvehicle_no.Text = veh_no;
                tbvehicle_type.Text = veh_type;
                tbvehicle_model.Text = veh_model;
                tbrate_per_day.Text = per_day;
                tbrate_per_week.Text = per_week;
                tbrate_per_month.Text = per_month;
                tbdriver_rate.Text = driver_rate;

                

            }
            else if (tbvehicle_no.Text == "")
            {
                MessageBox.Show("Enter a vehicle number");
            }
            else
            {
                MessageBox.Show("Record not availabe");
                tbvehicle_no.Text = "";
                tbvehicle_type.Text = "";
                tbvehicle_model.Text = "";
                tbrate_per_day.Text = "";
                tbrate_per_week.Text = "";
                tbrate_per_month.Text = "";
                tbdriver_rate.Text = "";
            }
            con.Close();
        }

        private void btncal_day_Click(object sender, EventArgs e)
        {
            DateTime rented_day = dt_rentted.Value.Date;
            DateTime retuened_day = dt_returend.Value.Date;

            int tot_days =((TimeSpan)(retuened_day - rented_day)).Days;
            lbtot_days.Text =Convert.ToString( tot_days);

            int month = tot_days / 30;
            int remainder = tot_days % 30;
            int weeks = remainder / 7;
            int days = remainder % 7;

            lbmonth.Text = Convert.ToString(month);
            lbweek.Text = Convert.ToString(weeks);
            lbday.Text = Convert.ToString(days);


        }

        private void dt_rentted_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncal_cost_Click(object sender, EventArgs e)
        {
            if (tbvehicle_no.Text == "")
            {
                MessageBox.Show("Vehicle number can not be empty");
            }
            else if (tbrate_per_day.Text == "")
            {
                MessageBox.Show("Rate per day can not be empty");
            }
            else if (tbrate_per_week.Text == "")
            {
                MessageBox.Show("Rate per week can not be empty");
            }
            else if (tbrate_per_month.Text == "")
            {
                MessageBox.Show("Rate per month can not be empty");
            }
            else if (tbdriver_rate.Text == "")
            {
                MessageBox.Show("Driver rate can not be empty");
            }
            else if (tbvehicle_model.Text == "")
            {
                MessageBox.Show("Vehicle model can not be empty");
            }
            else if (tbvehicle_type.Text == "")
            {
                MessageBox.Show("Vehicle can not be empty");
            }
            else if (lbtot_days.Text == "")
            {
                MessageBox.Show("Total days can not be empty");
            }
            else if (lbday.Text == "")
            {
                MessageBox.Show("Days can not be empty");
            }
            else if (lbweek.Text == "")
            {
                MessageBox.Show("Weeks can not be empty");
            }
            else if (lbmonth.Text == "")
            {
                MessageBox.Show("Month can not be empty");
            }
            else
            {
                double mothns = Convert.ToDouble(lbmonth.Text);
                double weeks = Convert.ToDouble(lbweek.Text);
                double days = Convert.ToDouble(lbday.Text);
                double day_rate = Convert.ToDouble(tbrate_per_day.Text);
                double week_per_rate = Convert.ToDouble(tbrate_per_week.Text);
                double month_rate = Convert.ToDouble(tbrate_per_month.Text);
                double driver_rate = Convert.ToDouble(tbdriver_rate.Text);
                double tot_days = Convert.ToDouble(lbtot_days.Text);

                if (driver_ckeck.Checked == true)
                {
                    double tot_cost = days * day_rate + weeks * week_per_rate + mothns * month_rate + driver_rate * tot_days;
                    lbcost.Text = Convert.ToString(tot_cost);
                }
                else
                {
                    double tot_cost = days * day_rate + weeks * week_per_rate + mothns * month_rate;
                    lbcost.Text = Convert.ToString(tot_cost);
                }
            }        
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbvehicle_no.Text = "";
            tbvehicle_type.Text = "";
            tbvehicle_model.Text = "";
            tbrate_per_day.Text = "";
            tbrate_per_week.Text = "";
            tbrate_per_month.Text = "";
            tbdriver_rate.Text = "";
            lbcost.Text = "";
            lbday.Text = "";
            lbweek.Text = "";
            lbmonth.Text = "";
            lbtot_days.Text = "";
        }
    }
}
