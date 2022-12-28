using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project2
{
    static class AllStaff
    {
        public static List<Staff> all_staff = new List<Staff>();

        public static void Rdata()
        {
            try
            {
                FileStream fs = new FileStream("staff.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split('&');
                    all_staff.Add(new Staff(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], Convert.ToInt32(data[8]), Convert.ToInt32(data[9]), Convert.ToInt32(data[10])));

                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateStaffData()
        {
            try
            {
                string d = AllStaff.all_staff[AllStaff.index].Pdata();

                string[] arr = File.ReadAllLines("staff.txt");
                arr[AllStaff.index] = d;
                File.WriteAllLines("staff.txt", arr);
                System.Windows.Forms.MessageBox.Show("Staff Updated");
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        public static int index;
        
    }
}
