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
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void cancelbtnac_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }

        private void btnsaveAC_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCus = new Customer(txtboxnameAC.Text,txtboxlnameAC.Text,txtboxaddressAC.Text,txtboxemailAC.Text,
                    txtboxcontactAC.Text, Convert.ToInt32(txtboxbalanceAC.Text),0,
                    comboboxplanAC.SelectedItem.ToString(),lblcusID.Text,lblaccountnumberAC.Text , pctboxAC.ImageLocation);

                FileStream cFile = new FileStream("Customer Data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(cFile);

                sw.WriteLine(newCus.Pdata());

                sw.Close();
                cFile.Close();
                MessageBox.Show("Succesfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            
            
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

            string anumber = "5540"+Rgenerator.Rnum3();

            string cusID = Rgenerator.CusID() + Rgenerator.Rnum1();
            

            lblaccountnumberAC.Text = anumber;
            lblcusID.Text = cusID;
        }

        private void btnbrowseAC_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.ShowDialog();
            string filePath = Openfile.FileName;
            pctboxAC.Load((filePath)); 
        }

        private void pctboxAC_Click(object sender, EventArgs e)
        {

        }
    }
}
