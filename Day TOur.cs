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
    public partial class Day_TOur : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public Day_TOur()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        public void clear()
        {
            tbpack_type.Text = "";
            tbpac_rate.Text = ""; 
            tbveh_type.Text = "";
            tbmax_km.Text = "";
            tbmax_hrs.Text = "";
            tbextre_km_rate.Text = "";
            tbextre_hrs_rate.Text = "";
            tbpack_ID.Text = "";
            btncal_cost.Enabled = false;
            btncal_hopur.Enabled = false;
            btncal_KM.Enabled = false;
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
                
                tbpack_type.Text = pack_type;
                tbpac_rate.Text = pack_rate;
                tbveh_type.Text = veh_type;
                tbmax_km.Text = max_km;
                tbmax_hrs.Text = max_hrs;
                tbextre_km_rate.Text = extra_km;
                tbextre_hrs_rate.Text = extra_hrs;

                btncal_hopur.Enabled = true;
                btncal_KM.Enabled = true;
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

        private void Day_TOur_Load(object sender, EventArgs e)
        {
            clear();
            tbpack_type.Enabled = false;
            tbpac_rate.Enabled = false;
            tbveh_type.Enabled = false;
            tbmax_km.Enabled = false;
            tbmax_hrs.Enabled = false;
            tbextre_km_rate.Enabled = false;
            tbextre_hrs_rate.Enabled = false;
        }

        private void btncal_hopur_Click(object sender, EventArgs e)
        {
            if (tbstart.Text == "")
            {
                MessageBox.Show("Start hour can't be empty");
            }
            else if(tbend.Text == "")
            {
                MessageBox.Show("End hour can't be empty");
            }
            else
            {
                double startime = Convert.ToDouble(tbstart.Text);
                double endtime = Convert.ToDouble(tbend.Text);
                double time_dif = endtime - startime;
                tot_hrs.Text = time_dif.ToString();
                double maxhrs = Convert.ToDouble(tbmax_hrs.Text);

                if (time_dif > maxhrs)
                {
                    double e_hrs = time_dif - maxhrs;
                    extra_hrs.Text = e_hrs.ToString();
                    double hrs_charge = Convert.ToDouble(tbextre_hrs_rate.Text);
                    Double ehrs_charge = e_hrs * hrs_charge;
                    extrahr_charge.Text = ehrs_charge.ToString();
                }
                else
                {
                    extra_hrs.Text = "0";
                    extrahr_charge.Text = "0";
                }

                if (tot_hrs.Text != "")
                {
                    btncal_cost.Enabled = true;
                }
                else
                {
                    btncal_cost.Enabled = false;
                }
            }
                     
        }

        private void btncal_KM_Click(object sender, EventArgs e)
        {
            if (tbstart_km.Text == "")
            {
                MessageBox.Show("Start km can't be empty");
            }
            else if(tbend_km.Text == "")
            {
                MessageBox.Show("End km can't be empty");
            }
            else
            {
                double start_km = Convert.ToDouble(tbstart_km.Text);
                double end_km = Convert.ToDouble(tbend_km.Text);
                double max_km = Convert.ToDouble(tbmax_km.Text);
                double e_km_rate = Convert.ToDouble(tbextre_km_rate.Text);
                
                lbextra_km_rate.Text = e_km_rate.ToString();
                
                double total_km = end_km - start_km;
                lbtot_Km.Text = total_km.ToString();

                if (total_km > max_km)
                {
                    double extra_km = total_km - max_km;
                    lbextra_km.Text = extra_km.ToString();
                   

                    double extra_km_charge = extra_km * e_km_rate;
                    lbextra_km_charge.Text = extra_km_charge.ToString();
                }
                else
                {
                    lbextra_km.Text = "0";
                    lbextra_km_charge.Text = "0";
                }
                if (lbtot_Km.Text != "")
                {
                    btncal_cost.Enabled = true;
                }
                else
                {
                    btncal_cost.Enabled = false;
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncal_cost_Click(object sender, EventArgs e)
        {
            if (tbpac_rate.Text == "")
            {
                MessageBox.Show("Package rate can not be empty");
            }
            else if (lbextra_km_charge.Text == "")
            {
                MessageBox.Show("Extr km charge can not be empty");

            }
            else if (extrahr_charge.Text=="")
            {
                MessageBox.Show("Extra hour charge can not be empty");

            }
            else
            {
                double pack_rate = Convert.ToDouble(tbpac_rate.Text);
                double extra_km_rate = Convert.ToDouble(lbextra_km_charge.Text);
                double extra_hrs_rate = Convert.ToDouble(extrahr_charge.Text);

                double total_cost = pack_rate + extra_km_rate + extra_hrs_rate;
                lbcost.Text = total_cost.ToString();
            }
            
        }
    }
}
