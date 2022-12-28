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
    public partial class ShowCustomer : Form
    {
        public ShowCustomer()
        {
            InitializeComponent();
        }

        private void SCbtnexit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }

        private void btneditSC_Click(object sender, EventArgs e)
        {
            EditCustomer ed1 = new EditCustomer();
            ed1.Show();
            this.Hide();
            
        }

        private void btncontrolbSC_Click(object sender, EventArgs e)
        {
            ControlBalance cb1 = new ControlBalance();
            cb1.Show();
            this.Hide();
            
        }
        public int index = 0;
        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            AllCust.all_customer.Clear();
            AllCust.Rdata();
            
            Ldata();
            label11.Text = (index + 1).ToString();
            AllCust.index = index;
            label13.Text = AllCust.all_customer.Count.ToString();            
        }
        public void Ldata()
        {
            lblnameSC.Text = AllCust.all_customer[index].Dname;
            lbllastnameSC.Text = AllCust.all_customer[index].Dlname;
            lbladdressSC.Text = AllCust.all_customer[index].Daddress;
            lblemailSC.Text = AllCust.all_customer[index].Demail;
            lblcontactSC.Text = AllCust.all_customer[index].Dcontact;
            lblbalanceSC.Text = AllCust.all_customer[index].Dbalance.ToString();
            lblplanSC.Text = AllCust.all_customer[index].Dplan();
            lblcustomerIDSC.Text = AllCust.all_customer[index].Did();
            lblaccountnumSC.Text = AllCust.all_customer[index].Daccountnum();
            lblsavingSC.Text = AllCust.all_customer[index].Dsavings.ToString();
            pictureboxSC.Load(AllCust.all_customer[index].Dimgloc);

        }

        private void btnrightSC_Click(object sender, EventArgs e)
        {
            index++;
            if (index==AllCust.all_customer.Count)
            {
                index = 0;
            }
            label11.Text = (index + 1).ToString();
            AllCust.index = index;
            Ldata();
        }

        private void btnleftSC_Click(object sender, EventArgs e)
        {
            index--;
            if (index==-1)
            {
                index = AllCust.all_customer.Count - 1;
            }
            label11.Text = (index + 1).ToString();
            AllCust.index = index;
            Ldata();
        }
    }
}
