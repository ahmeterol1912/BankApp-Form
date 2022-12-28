using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO ;

namespace Project2
{
    class Person
    {
       
    }

    class Customer : Person
    {
        string ID, accountnum, plan;
        int balance,savings=0;
        string name, lastname, address, email, contact, imgLoc;
        public Customer(string name,string lastname, string address,
            string email,string contact,int balance,int savings, string plan, string ID,string accountnum, string imgLoc)
        {
            this.name = name;
            this.lastname = lastname;
            this.address = address;
            this.email = email;
            this.contact = contact;
            this.balance = balance;
            this.plan = plan;
            this.ID = ID;
            this.imgLoc = imgLoc;
            this.accountnum = accountnum;
            this.savings = savings;
        }
        
        public string Dname
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Dlname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string Daddress
        {
            get { return this.address; }
            set { this.address = value; }
        }

        
        public string Demail
        {
            get { return this.email; }
            set { this.email = value; } 
        }

        public string Dcontact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

        public int Dbalance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public string Dplan()
        {
            return this.plan;
        }

        public string Did()
        {
            return this.ID;
        }

        public string Daccountnum()
        {
            return this.accountnum;
        }

        public string Dimgloc
        {
            get { return this.imgLoc; }
            set { this.imgLoc = value; }    
        }

        public int Dsavings
        {
            get { return this.savings; }
            set { this.savings = value; }
        }
        public string Pdata()
        {
            return $"{this.name}&{this.lastname}&{this.address}&{this.email}&{this.contact}&{this.balance}&{this.savings}&{this.plan}&{this.ID}&{this.accountnum}&{this.imgLoc}";
        }
    }

    
}
