using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class StaffManaging : Form
    {
        public StaffManaging()
        {
            InitializeComponent();
        }

        private void btnexitSM_Click(object sender, EventArgs e)
        {
            AllStaff.all_staff[AllStaff.index].Hours = Convert.ToInt32( lblunhoursSM.Text);
            AllStaff.all_staff[AllStaff.index].Extrahr = Convert.ToInt32( lblexhoursSM.Text);
            AllStaff.all_staff[AllStaff.index].Balance = Convert.ToInt32( lblunbalanceSM.Text);

            AllStaff.UpdateStaffData();
            
            ShowStaff ss1 = new ShowStaff();
            ss1.Show();
            this.Hide();
        }
        int pay;
        int expay;
        private void StaffManaging_Load(object sender, EventArgs e)
        {
            txtboxextrahourSM.Text = 0.ToString();
            txtboxnormalhourSM.Text = 0.ToString();
            if (AllStaff.all_staff[AllStaff.index].Role() == "CEO")
            {
                pay = 150;
                expay = 200;
            }
            else if (AllStaff.all_staff[AllStaff.index].Role() == "Manager")
            {
                pay = 100;
                expay = 130;
            }
            else if (AllStaff.all_staff[AllStaff.index].Role() == "Assistant")
            {
                pay = 70;
                expay = 90;
            }
            else if (AllStaff.all_staff[AllStaff.index].Role() == "Worker")
            {
                pay = 50;
                expay = 65;
            }

            lblstaffidSM.Text = AllStaff.all_staff[AllStaff.index].Id();
            lblunhoursSM.Text = AllStaff.all_staff[AllStaff.index].Hours.ToString();
            lblexhoursSM.Text = AllStaff.all_staff[AllStaff.index].Extrahr.ToString();
            lblunbalanceSM.Text = AllStaff.all_staff[AllStaff.index].Balance.ToString();
        }

        private void btnpaySM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salary payed");
            lblunhoursSM.Text = 0.ToString();
            lblexhoursSM.Text = 0.ToString();
            lblunbalanceSM.Text = 0.ToString();
        }

        private void btnaddhoursSM_Click(object sender, EventArgs e)
        {
            AllStaff.all_staff[AllStaff.index].Hours += Convert.ToInt32( txtboxnormalhourSM.Text);
            AllStaff.all_staff[AllStaff.index].Extrahr += Convert.ToInt32( txtboxextrahourSM.Text);
            AllStaff.all_staff[AllStaff.index].Balance += (Convert.ToInt32(txtboxnormalhourSM.Text)*pay) + Convert.ToInt32(txtboxextrahourSM.Text)*expay;

            MessageBox.Show("Hours added!");
            txtboxextrahourSM.Text = 0.ToString();
            txtboxnormalhourSM.Text = 0.ToString();
            lblunhoursSM.Text = AllStaff.all_staff[AllStaff.index].Hours.ToString();
            lblexhoursSM.Text = AllStaff.all_staff[AllStaff.index].Extrahr.ToString();
            lblunbalanceSM.Text = AllStaff.all_staff[AllStaff.index].Balance.ToString();
        }
    }
}
