using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project2
{
    static class AllCust
    {
        public static List<Customer> all_customer = new List<Customer>();

        public static void Rdata()
        {
            try
            {
                FileStream fs = new FileStream("Customer Data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split('&');
                    all_customer.Add(new Customer(data[0], data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]),Convert.ToInt32(data[6]), data[7], data[8], data[9], data[10]));

                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

            public static int index;

        public static void UpdateCustomerData()
        {
            try
            {
                string d = AllCust.all_customer[AllCust.index].Pdata();
                
                string[] arr = File.ReadAllLines("Customer Data.txt");
                arr[AllCust.index] = d;
                File.WriteAllLines("Customer Data.txt", arr);
                System.Windows.Forms.MessageBox.Show("Customer Updated");
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }
    }



}
