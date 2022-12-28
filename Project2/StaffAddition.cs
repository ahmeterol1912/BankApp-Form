using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project2
{
    class StaffAddition
    {

    }

    class Staff : StaffAddition
    {
        string ID; 
        int salary;
        int hours=0, extrahr=0, balance=0;
        string name, lastname, address, email, contact, role, imgLoc;

        public Staff(string name, string lastname, string address,
            string email, string contact, string role, string ID, string imgLoc, int hours, int extrahr, int balance)
        {
            this.name = name;
            this.lastname = lastname;
            this.address = address;
            this.email = email;
            this.contact = contact;
            this.role = role;
            this.ID = ID;
            this.imgLoc = imgLoc;
            this.hours = hours;
            this.extrahr = extrahr;
            this.balance = balance;
        }
        public int Hours { get { return this.hours; }  set { this.hours = value;  } }

        public int Extrahr { get { return this.extrahr; } set { this.extrahr = value; } }

        public int Balance { get { return this.balance; } set { this.balance = value; } }

        public string Name()
        {
            return this.name;
        }

        public string Lname()
        {
            return this.lastname;
        }

        public string Address()
        {
            return this.address;
        }

        public string Email()
        {
            return this.email;
        }

        public string Contact()
        {
            return this.contact;
        }

        public string Role()
        {
            return this.role;
        }

        public string Id()
        {
            return this.ID;
        }

        public string Imgloc()
        {
            return this.imgLoc;
        }
        public int Salary()
        {
            return this.salary;
        }
        

        public string Pdata()
        {
            return $"{this.name}&{this.lastname}&{this.address}&{this.email}&{this.contact}&{this.role}&{this.ID}&{this.imgLoc}&{this.hours}&{this.extrahr}&{this.balance}";
        }

        
    }
}
