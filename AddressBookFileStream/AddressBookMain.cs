using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookFileStream
{
    public class AddressBookMain
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }


        public AddressBookMain(string firstName, string lastName, string address, string state, string zip, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
        public AddressBookMain() { 

        }
    }

}

