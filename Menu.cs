using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle Vehicle1 = new Vehicle();
            Vehicle1.Show();
        }

        private void btnpackage_Click(object sender, EventArgs e)
        {
            this.Hide();
            package package1 = new package();
            package1.Show();
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rent rent = new Rent();
            rent.Show();
        }

        private void btnday_tour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Day_TOur day_TOur= new Day_TOur();
            day_TOur.Show();
        }

        private void btnlong_tour_Click(object sender, EventArgs e)
        {
            this.Hide();
            LongTour longTour = new LongTour();
            longTour.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure to logout", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == msg)
            {
                this.Hide();
                Login Loginpage = new Login();
                Loginpage.Show();
            }
        }
    }
}
