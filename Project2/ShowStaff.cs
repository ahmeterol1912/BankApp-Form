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
    public partial class ShowStaff : Form
    {
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void btnexitSS_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnmanagingSS_Click(object sender, EventArgs e)
        {
            AllStaff.index = this.index;
            StaffManaging sm1 = new StaffManaging();
            sm1.Show();
            this.Hide();
        }
        public int index = 0;

        public void Work()
        {
            Payment payment = new Payment();


            if (lblroleSS.Text == "CEO")
            {
                lblsalerySS.Text = "150";
            }
            else if (lblroleSS.Text == "Manager")
            {
                lblsalerySS.Text = "100";
            }
            else if (lblroleSS.Text == "Assistant")
            {
                lblsalerySS.Text = "70";
            }
            else if (lblroleSS.Text == "Worker")
            {
                lblsalerySS.Text = "50";
            }
        }
        private void ShowStaff_Load(object sender, EventArgs e)
        {
            AllStaff.all_staff.Clear();
            
            AllStaff.Rdata();
            sdata();

            label13.Text = (index + 1).ToString();
            AllStaff.index = index;
            
            label14.Text = AllStaff.all_staff.Count.ToString();
            Work();
            
        }

        public void sdata()
        {
            lblidSS.Text = AllStaff.all_staff[index].Id();
            lblnameSS.Text = AllStaff.all_staff[index].Name();
            lbllastnameSS.Text = AllStaff.all_staff[index].Lname();
            lblemailSS.Text = AllStaff.all_staff[index].Email();
            lblpnumberSS.Text = AllStaff.all_staff[index].Contact();
            lbladdressSS.Text = AllStaff.all_staff[index].Address();
            lblroleSS.Text = AllStaff.all_staff[index].Role();
            lblhoursSS.Text = AllStaff.all_staff[index].Hours.ToString();
            lblextrahoursSS.Text = AllStaff.all_staff[index].Extrahr.ToString();
            lblbalanceSS.Text = AllStaff.all_staff[index].Balance.ToString();
            pictureboxSS.Load(AllStaff.all_staff[index].Imgloc());
        }

        private void btnrightSS_Click(object sender, EventArgs e)
        {
            index++;
            if (index == AllStaff.all_staff.Count)
            {
                index = 0;
            }
            label13.Text = (index + 1).ToString();
            AllStaff.index = index;
            sdata();
            Work();
        }

        private void btnleftSS_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = AllStaff.all_staff.Count - 1;
            }
            label13.Text = (index + 1).ToString();
            AllStaff.index = index;
            sdata();
            Work();
        }

        
    }
}
