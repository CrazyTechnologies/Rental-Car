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
    public partial class LongTour : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");

        public LongTour()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        

        private void btnserachpack_Click(object sender, EventArgs e)
        {
            con.Open();

            string search = "Select * From Package where Package_Id='" + tbpack_ID.Text + "' ";
            SqlCommand com = new SqlCommand(search, con);
            com.ExecuteNonQuery();
            SqlDataReader dr;
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                string pack_type = dr["Package_Type"].ToString();
                string pack_rate = dr["Package_Rate"].ToString();
                string veh_type = dr["Vehicle_Type"].ToString();
                string max_km = dr["Max_KM"].ToString();
                string max_hrs = dr["Max_Hour"].ToString();
                string extra_km = dr["Extra_KM_Rate"].ToString();
                string extra_hrs = dr["Extra_Hour_Rate"].ToString();
                string veh_night = dr["Vehichle_Night_Rate"].ToString();
                string dri_night = dr["Driver_Night_Rate"].ToString();
                
                tbpack_type.Text = pack_type;
                tbpac_rate.Text = pack_rate;
                tbveh_type.Text = veh_type;
                tbmax_km.Text = max_km;
                tbmax_hrs.Text = max_hrs;
                tbextre_km_rate.Text = extra_km;
                tbextre_hrs_rate.Text = extra_hrs;
                tbveh_night_rate.Text = veh_night;
                tbdriver_night_rate.Text = dri_night;

                lbtot_pack_rate.Text = pack_rate;
                btncal_km.Enabled = true;
                btncal_day.Enabled = true;
                
            }
            else if (tbpack_ID.Text == "")
            {
                MessageBox.Show("Enter package ID ");
            }
            else
            {
                MessageBox.Show("Record not availabe");
                tbpack_ID.Text = "";
            }
            con.Close();
        }

        private void LongTour_Load(object sender, EventArgs e)
        {
            tbpack_type.Enabled = false;
            tbpac_rate.Enabled = false;
            tbveh_type.Enabled = false;
            tbmax_km.Enabled = false;
            tbmax_hrs.Enabled = false;
            tbextre_km_rate.Enabled = false;
            tbextre_hrs_rate.Enabled = false;
            tbveh_night_rate.Enabled = false;
            tbdriver_night_rate.Enabled = false;
            btncal_km.Enabled = false;
            btncal_day.Enabled = false;
            btncal_Amount.Enabled = false;

           
                    
        }

        private void btncal_km_Click(object sender, EventArgs e)
        {
            if (tbs_km.Text == "")
            {
                MessageBox.Show("Enter stsr Km");
            }
            else if (tbe_km.Text == "")
            {
                MessageBox.Show("Enter end Km");
            }
            else if (tbmax_km.Text=="")
            {
                MessageBox.Show("Maximum Km in package can not be empty");
            }
            else
            {
                double start_km = Convert.ToDouble(tbs_km.Text);
                double end_km = Convert.ToDouble(tbe_km.Text);
                double max_km = Convert.ToDouble(tbmax_km.Text);

                double tot_km = end_km - start_km;
                lbtot_km.Text = Convert.ToString(tot_km);
                lbextra_km_rate.Text = tbextre_km_rate.Text;

                if (tot_km > max_km)
                {
                    double extra_km = tot_km - max_km;
                    lbextra_km.Text = Convert.ToString(extra_km);
                    lbextra_km_rate.Text = tbextre_km_rate.Text;
                    double extra_km_rate = Convert.ToDouble(lbextra_km_rate.Text);
                    double extra_charge = extra_km * extra_km_rate;
                    lbextra_charge.Text = Convert.ToString(extra_charge);
                    lbkm_charge.Text = Convert.ToString(extra_charge);
                }
                else
                {
                    lbextra_km.Text = "0";
                    lbextra_charge.Text = "0";
                    lbkm_charge.Text = "0";
                }
            }
            if (lbkm_charge.Text != "")
            {
                if (lbnight_cost.Text != "")
                {
                    btncal_Amount.Enabled = true;
                }
                else
                {
                    btncal_Amount.Enabled = false;
                }
            }
            else if (lbnight_cost.Text != "")
            {
                if (lbkm_charge.Text != "")
                {
                    btncal_Amount.Enabled = true;
                }
                else
                {
                    btncal_Amount.Enabled = false;
                }
            }
            else
            {
                btncal_Amount.Enabled = false;
            }
        }

        private void btncal_day_Click(object sender, EventArgs e)
        {
            DateTime rented_day = dt_rentted.Value.Date;
            DateTime retuened_day = dt_returend.Value.Date;

            int tot_days = ((TimeSpan)(retuened_day - rented_day)).Days;
            lbtot_days.Text = Convert.ToString(tot_days);

            Double driver_rate=Convert.ToDouble(tbdriver_night_rate.Text);
            Double vehicle_rate = Convert.ToDouble(tbveh_night_rate.Text);

            Double night_cost=driver_rate*tot_days+vehicle_rate*tot_days;
            lbnight_cost.Text = Convert.ToString(night_cost);

            if (lbkm_charge.Text != "")
            {
                if (lbnight_cost.Text != "")
                {
                    btncal_Amount.Enabled = true;
                }
                else
                {
                    btncal_Amount.Enabled = false;
                }
            }
            else if (lbnight_cost.Text != "")
            {
                if (lbkm_charge.Text != "")
                {
                    btncal_Amount.Enabled = true;
                }
                else
                {
                    btncal_Amount.Enabled = false;
                }
            }
            else
            {
                btncal_Amount.Enabled = false;
            }
        }

        private void btncal_Amount_Click(object sender, EventArgs e)
        {
            double pack_rate=Convert.ToDouble(lbtot_pack_rate.Text);
            double extra_km=Convert.ToDouble(lbkm_charge.Text);
            double night_cost=Convert.ToDouble(lbnight_cost.Text);

            double totalcost = pack_rate + extra_km + night_cost;
            lbtotalcost.Text = Convert.ToString(totalcost);
        }
    }
}
