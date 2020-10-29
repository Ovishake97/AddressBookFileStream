using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AddressBookFileStream
{
    public class JSONReader
    {
        public void JSonReadData() {
        string jsonFilePath = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.json";
           //Opens a text file and retruns a string containing the text files
            JObject jsonObj = JObject.Parse(File.ReadAllText(jsonFilePath));
            //creating a JToken file from the available filepath  
            using (StreamReader file = File.OpenText(jsonFilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                //typecasting the JToken object to a JObject object and reading the values from it
                JObject obj = (JObject)JToken.ReadFrom(reader);
                foreach (var element in obj) {
                    Console.WriteLine(element.Value);
                }
            }
                        
    }
        /// Taking input from the user and serialising the files to a json file and storing it in the address book
        public void JSonWriteData() {
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
            string jsonFilePath = @"C:\Users\abhishek\Desktop\File IO\AddressBookFileStream\AddressBookFileStream\AddressBook.json";
            JsonSerializer jsonSerializer = new JsonSerializer();
            var writer = new StreamWriter(jsonFilePath);
            jsonSerializer.Serialize(writer, addressBookMain);
            writer.Flush();
        }

       
    }
}
