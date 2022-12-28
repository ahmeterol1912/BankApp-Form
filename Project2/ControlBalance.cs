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
    public partial class ControlBalance : Form
    {
        public ControlBalance()
        {
            InitializeComponent();
        }

        private void btnexitCB_Click(object sender, EventArgs e)
        {
            AllCust.all_customer[AllCust.index].Dbalance = Convert.ToInt32(lblbalanceCB.Text);
            AllCust.all_customer[AllCust.index].Dsavings = Convert.ToInt32(lblsavingCB.Text);
            AllCust.UpdateCustomerData();
            ShowCustomer f3 = new ShowCustomer();
            f3.Show();
            this.Hide();
        }

        private void ControlBalance_Load(object sender, EventArgs e)
        {
            lblaccountnumCB.Text = AllCust.all_customer[AllCust.index].Daccountnum();
            lblcustomeridCB.Text = AllCust.all_customer[AllCust.index].Did();
            lblbalanceCB.Text = AllCust.all_customer[AllCust.index].Dbalance.ToString();
            lblsavingCB.Text = AllCust.all_customer[AllCust.index].Dsavings.ToString();
            txtboxwithdrawCB.Text = 0.ToString(); txtboxmovingCB.Text = 0.ToString(); txtboxdepositCB.Text = 0.ToString();
        }

        private void btnwithdrawCB_Click(object sender, EventArgs e)
        {
            AllCust.all_customer[AllCust.index].Dbalance -= Convert.ToInt32(txtboxwithdrawCB.Text);
            lblbalanceCB.Text = AllCust.all_customer[AllCust.index].Dbalance.ToString();
            MessageBox.Show("Successful");
            txtboxwithdrawCB.Text = 0.ToString();

        }

        private void btnmovingCB_Click(object sender, EventArgs e)
        {
            try
            {
                AllCust.all_customer[AllCust.index].Dbalance -= Convert.ToInt32(txtboxmovingCB.Text);
                AllCust.all_customer[AllCust.index].Dsavings += Convert.ToInt32(txtboxmovingCB.Text);
                lblsavingCB.Text = AllCust.all_customer[AllCust.index].Dsavings.ToString();
                lblbalanceCB.Text = AllCust.all_customer[AllCust.index].Dbalance.ToString();
                MessageBox.Show("Successful");
                txtboxmovingCB.Text = 0.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btndepositCB_Click(object sender, EventArgs e)
        {
            AllCust.all_customer[AllCust.index].Dbalance += Convert.ToInt32(txtboxdepositCB.Text);
            lblbalanceCB.Text = AllCust.all_customer[AllCust.index].Dbalance.ToString();
            MessageBox.Show("Successful");
            txtboxdepositCB.Text = 0.ToString();
        }
    }
}
