using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace AddressBookFileStream
{
    public class CSVReader
    {
        public List<AddressBookMain> addressBook = new List<AddressBookMain>();
        public void CSVDataReading() {
            string csvFilePath = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ",";
                var records = csv.GetRecords<AddressBookMain>();
                foreach (AddressBookMain address in records)
                {
                    Console.Write("\t" + address.firstName);
                    Console.Write("\t" + address.lastName);
                    Console.Write("\t" + address.address);
                    Console.Write("\t" + address.state);
                    Console.Write("\t" + address.zip);
                    Console.Write("\t" + address.phone);
                    Console.Write("\t" + address.email);
                    Console.WriteLine("\n");
                }
                reader.Close();
            }
            
        }
        public void CSVDataWriting() {
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
            AddressBookMain addressBookMain = new AddressBookMain(firstName, lastName, address, state, zip, phone, email);
            string csvFilePath = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.csv";
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                string record = firstName + "," + lastName + "," + address + "," + state + "," + zip + "," + phone + "," + email;
                csv.WriteHeader<AddressBookMain>();
                csv.NextRecord();
                csv.WriteRecord<AddressBookMain>(addressBookMain);
                writer.Flush();
            }   
        }
    }
}
