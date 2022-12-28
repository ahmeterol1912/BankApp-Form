using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class Rgenerator
    {
        public static string Rnum3()
        {
            
            string number="";
            Random rnum = new Random();
            for (int i = 0; i < 3; i++)
            {
                number += "-"+rnum.Next(1000, 10000).ToString();
            }
            
            return number;
            
        }

        public static string Rnum1()
        {

            string number = "";
            Random rnum1 = new Random();

            for (int i = 0; i < 4; i++)
            {
                number = "-" + rnum1.Next(1000, 10000).ToString();
            }
            
            

            return number;

        }

        public static string CusID()
        {
            string[] letters = { "A", "B", "C", "D" };
            Random a = new Random();
            int b;
            b = a.Next(0,4);
            return letters[b];
        }

        public static string StaffID()
        {
            string[] letters = { "X", "Y", "W", "Z" };
            Random a = new Random();
            int b;
            b = a.Next(0, 4);
            return letters[b];
        }
    }
}
