using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddressBookFileStream
{
    public class FileStream
    {
        public List<string> addressBook = new List<string>();
        /// This method checks whether the the path
        /// exists or not and accordingly sends boolean results
        public static bool FileExist(string path) {
            if (File.Exists(path))
            {
                return true;
            }
            else {
                return false;
            }
        }
        /// The method is used to read the files by giving the path of the file 
        /// and reading each text using StreamReader class
        public void ReadFile() {
            string path = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.txt";
            bool flag = FileExist(path);
            if (flag == true)
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = " ";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        Console.WriteLine("-------");
                    }
                }
            }
            else {
                throw new Exception("File doesn't exist");
            }
        }
        /// Writes a string in the exisiting file
        /// with the help of StreamWriter class
        public void WriteIntoFile(string data) {
            string path = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.txt";
            bool flag = FileExist(path);
            if (flag == true)
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(data);
                    sr.Close();
                }
            }
            else {
                throw new Exception("File doesn't exist");
            }
        }
        /// Takes input from the user and
        /// calls the WriteIntoFile method to enter the data
        public void EnterData() {
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the city");
            string address = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            AddToAddressBook(firstName, lastName, address, state, zip, phone, email);
            foreach (string data in addressBook) {
                WriteIntoFile(data);
            }
        }
        /// Adds data to the addressbook list
        public void AddToAddressBook(string firstName, string lastName, string address, string state, string zip, string phone, string email)
        {
            AddressBookMain addressBookMain = new AddressBookMain(firstName, lastName, address, state, zip, phone, email);
            addressBook.Add(addressBookMain.firstName);
            addressBook.Add(addressBookMain.lastName);
            addressBook.Add(addressBookMain.address);
            addressBook.Add(addressBookMain.state);
            addressBook.Add(addressBookMain.zip);
            addressBook.Add(addressBookMain.phone);
            addressBook.Add(addressBookMain.email);
        }
    }
}
