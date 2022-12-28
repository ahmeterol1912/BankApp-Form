using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        

        private void btnmodifyEC_Click(object sender, EventArgs e)
        {
            AllCust.all_customer[AllCust.index].Dname = txtboxnameEC.Text;
            AllCust.all_customer[AllCust.index].Dlname = txtboxlastnameEC.Text;
            AllCust.all_customer[AllCust.index].Daddress = txtboxaddressEC.Text;
            AllCust.all_customer[AllCust.index].Dcontact = txtboxcontactEC.Text;
            AllCust.all_customer[AllCust.index].Dimgloc = pictureboxEC.ImageLocation;

            AllCust.UpdateCustomerData();
            ShowCustomer f3 = new ShowCustomer();
            f3.Show();
            this.Hide();
            this.Close();
        }

        private void btncancelEC_Click(object sender, EventArgs e)
        {
            ShowCustomer f3 = new ShowCustomer();
            f3.Show();
            this.Hide();
            this.Close();
        }
        public void Ldata()
        {
            txtboxnameEC.Text = AllCust.all_customer[AllCust.index].Dname;
            txtboxlastnameEC.Text = AllCust.all_customer[AllCust.index].Dlname;
            txtboxaddressEC.Text = AllCust.all_customer[AllCust.index].Daddress;
            txtboxemailEC.Text = AllCust.all_customer[AllCust.index].Demail;
            txtboxcontactEC.Text = AllCust.all_customer[AllCust.index].Dcontact;
            lblbalanceEC.Text = AllCust.all_customer[AllCust.index].Dbalance.ToString();
            lblplanEC.Text = AllCust.all_customer[AllCust.index].Dplan();
            lblcustomeridEC.Text = AllCust.all_customer[AllCust.index].Did();
            lblaccountnumEC.Text = AllCust.all_customer[AllCust.index].Daccountnum();
            lblsavingsEC.Text = AllCust.all_customer[AllCust.index].Dsavings.ToString();
            pictureboxEC.Load(AllCust.all_customer[AllCust.index].Dimgloc);
        }
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            Ldata();
            //MessageBox.Show("Please edit all your data!!!");
        }

        private void btnimageEC_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.ShowDialog();
            string filePath = Openfile.FileName;
            pictureboxEC.Load((filePath));
        }
    }
}
