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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnsaveAS_Click(object sender, EventArgs e)
        {
            try
            {
                Staff sf = new Staff(txtboxnameAS.Text, txtboxlastnameAS.Text, txtboxaddressAS.Text, txtboxemailAS.Text, txtboxcontactAS.Text, txtboxroleAS.Text, lblstaffidAS.Text, pctboxAS.ImageLocation,0,0,0);
                FileStream sfile = new FileStream("staff.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(sfile);
                sw.WriteLine(sf.Pdata());
                sw.Close();
                sfile.Close();
                MessageBox.Show("Staff Member Added");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btncancelAS_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            string cusID = Rgenerator.StaffID() + Rgenerator.Rnum1();
            lblstaffidAS.Text = cusID;
        }

        private void btnbrowseAS_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.ShowDialog();
            string filePath = Openfile.FileName;
            pctboxAS.Load((filePath));
        }
    }
}
