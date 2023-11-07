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
    public partial class package : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8IL9QDK;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        public package()
        {
            InitializeComponent();
        }

        public void clear()
        {
            tbpack_ID.Text = "";
            tbpack_type.Text = "";
            tbpac_rate.Text = "";
            tbveh_type.Text = "";
            tbmax_km.Text = "";
            tbmax_hrs.Text = "";
            tbextre_km_rate.Text = "";
            tbextre_hrs_rate.Text = "";
            tbveh_night_rate.Text = "";
            tbdriver_night_rate.Text ="";
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            btnadd.Enabled = true;
            tbpack_ID.Enabled = true;
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void package_Load(object sender, EventArgs e)
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
                tbpack_ID.Enabled = false;

                tbpack_type.Text = pack_type;
                tbpac_rate.Text = pack_rate;
                tbveh_type.Text = veh_type;
                tbmax_km.Text = max_km;
                tbmax_hrs.Text = max_hrs;
                tbextre_km_rate.Text = extra_km;
                tbextre_hrs_rate.Text = extra_hrs;
                tbveh_night_rate.Text = veh_night;
                tbdriver_night_rate.Text = dri_night;

                btnadd.Enabled = false;
                btndelete.Enabled = true;
                btnedit.Enabled = true;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();

            string pack_ID = tbpack_ID.Text;


            string search = "Select * from Package where Package_Id='" + tbpack_ID.Text + "'";
            SqlCommand com = new SqlCommand(search, con);
            SqlDataReader dr;
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Record already exists");
                tbpack_ID.Text = "";
            }
            else if (tbpack_ID.Text == "")
            {
                MessageBox.Show("Enter package ID");
            }
            else if (tbpack_type.Text == "")
            {
                MessageBox.Show("Enter package type");
            }
            else if (tbpac_rate.Text == "")
            {
                MessageBox.Show("Enter package rate");
            }
            else if (tbveh_type.Text == "")
            {
                MessageBox.Show("Enter vehicle type");
            }
            else if (tbmax_km.Text == "")
            {
                MessageBox.Show("Enter maximum km");
            }
            else if (tbmax_hrs.Text == "")
            {
                MessageBox.Show("Enter maximum hour");
            }
            else if (tbextre_km_rate.Text == "")
            {
                MessageBox.Show("Enter extra km rate");
            }
            else if (tbextre_hrs_rate.Text == "")
            {
                MessageBox.Show("Enter extra hour rate");
            }
            else if (tbveh_night_rate.Text == "")
            {
                MessageBox.Show("Enter vehicle night rate");
            }
            else if (tbdriver_night_rate.Text == "")
            {
                MessageBox.Show("Enter driver night rate");
            }
            else
            {
                conn.Open();

                int p_ID = Convert.ToInt32(tbpack_ID.Text);
                string pack_type = tbpack_ID.Text;
                double pack_rate = Convert.ToDouble(tbpac_rate.Text);
                string veh_type = tbveh_type.Text;
                double max_km = Convert.ToDouble(tbmax_km.Text);
                int max_hrs = Convert.ToInt32(tbmax_hrs.Text);
                double extra_km = Convert.ToDouble(tbextre_km_rate.Text);
                double extra_hrs = Convert.ToDouble(tbextre_hrs_rate.Text);
                double veh_night = Convert.ToDouble(tbveh_night_rate.Text);
                double dri_night = Convert.ToDouble(tbdriver_night_rate.Text);
                
                string insert = "Insert into Package (Package_Id,Package_Type,Package_Rate,Vehicle_Type,Max_KM,Max_Hour,Extra_KM_Rate,Extra_Hour_Rate,Vehichle_Night_Rate,Driver_Night_Rate)Values('" + tbpack_ID.Text + "','" + tbpack_type.Text + "','" + tbpac_rate.Text + "','" + tbveh_type.Text + "','" + tbmax_km.Text + "','" + tbmax_hrs.Text + "','" + tbextre_km_rate.Text + "','" + tbextre_hrs_rate.Text + "','" + tbveh_night_rate.Text + "','" + tbdriver_night_rate.Text + "') ";

                SqlCommand comm = new SqlCommand(insert, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Record successfully saved");
                clear();

                conn.Close();
            }
            con.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (tbpack_ID.Text == "")
            {
                MessageBox.Show("Enter package ID");
            }
            else if (tbpack_type.Text == "")
            {
                MessageBox.Show("Enter package type");
            }
            else if (tbpac_rate.Text == "")
            {
                MessageBox.Show("Enter package rate");
            }
            else if (tbveh_type.Text == "")
            {
                MessageBox.Show("Enter vehicle type");
            }
            else if (tbmax_km.Text == "")
            {
                MessageBox.Show("Enter maximum km");
            }
            else if (tbmax_hrs.Text == "")
            {
                MessageBox.Show("Enter maximum hour");
            }
            else if (tbextre_km_rate.Text == "")
            {
                MessageBox.Show("Enter extra km rate");
            }
            else if (tbextre_hrs_rate.Text == "")
            {
                MessageBox.Show("Enter extra hour rate");
            }
            else if (tbveh_night_rate.Text == "")
            {
                MessageBox.Show("Enter vehicle night rate");
            }
            else if (tbdriver_night_rate.Text == "")
            {
                MessageBox.Show("Enter driver night rate");
            }
            else
            {
                con.Open();
                
                string update = "Update Package set Package_Type='"+tbpack_type.Text+"', Package_Rate='"+tbpac_rate.Text+"', Vehicle_Type='"+tbveh_type.Text+ "', Max_KM='"+tbmax_km.Text+"', Max_Hour='" + tbmax_hrs.Text+"', Extra_KM_Rate='"+tbextre_km_rate.Text+"', Extra_Hour_Rate='"+tbextre_hrs_rate.Text+"',Vehichle_Night_Rate='"+tbveh_night_rate.Text+"', Driver_Night_Rate='"+tbdriver_night_rate.Text+"' where Package_Id='" + tbpack_ID.Text + "' ";
                SqlCommand com = new SqlCommand(update, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record successfully updated");
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

                string delete = "Delete from Package where Package_Id='" + tbpack_ID.Text + "'";
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
