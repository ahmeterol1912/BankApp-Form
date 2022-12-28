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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddc_Click(object sender, EventArgs e)
        {
            Add_Customer f2 = new Add_Customer();
            f2.Show();
            this.Hide();
            

        }

        private void btnshowc_Click(object sender, EventArgs e)
        {
            ShowCustomer f3 = new ShowCustomer();
            f3.Show();
            this.Hide();
            
        }

        private void btnexitform1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadds_Click(object sender, EventArgs e)
        {
            AddStaff as1 = new AddStaff();
            as1.Show();
            this.Hide();
            

        }

        private void btnshows_Click(object sender, EventArgs e)
        {
            ShowStaff ss1 = new ShowStaff();
            ss1.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllCust.all_customer.Clear();
            AllStaff.all_staff.Clear();
            // AllCust.Rdata();
            //MessageBox.Show(AllCust.all_customer.Count.ToString()); //AllCust.all_customer.Count
        }
    }
}
