using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookFileStream
{
    public class AddressBookMain
    {
        public string firstName;
        public string lastName;
        public string address;
        public string state;
        public string zip;
        public string phone;
        public string email;


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
        
    }

}

