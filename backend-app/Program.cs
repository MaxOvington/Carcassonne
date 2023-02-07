using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Collections;

namespace Carcassonne {

    class Program {
        static void Main(string[] args) {

            var reader = new System.IO.StreamReader(@"example.json", System.Text.Encoding.UTF8);
            String text = reader.ReadToEnd();
            List<Property> properties = (text == "") ? new List<Property>() : JsonSerializer.Deserialize<List<Property>>(text) ?? throw new ArgumentNullException("String Values cannot be null, invalid format!\n");
            reader.Close();

            Console.WriteLine("Welcome to the Carcassonne Backend!");
            Console.WriteLine("Enter a command: \n");
            Console.WriteLine("Add Property (1)\n");
            Console.WriteLine("Print Properties (2)\n");
            Console.WriteLine("Delete Propeties (3)\n");
            Console.WriteLine("Change Property Details (4)\n");

            string? input = Console.ReadLine();
            if (input == "1") {
                Console.WriteLine("Enter the suburb street, price, number of bedrooms, bathrooms and garage spaces\n");
                string? suburb;
                string? street;
                suburb = Console.ReadLine() ?? throw new ArgumentNullException("String Values cannot be null, invalid format!\n");
                street = Console.ReadLine() ?? throw new ArgumentNullException("String Values cannot be null, invalid format!\n");
                int price = Convert.ToInt32(Console.ReadLine());
                int bedrooms = Convert.ToInt32(Console.ReadLine());
                int bathrooms = Convert.ToInt32(Console.ReadLine());
                int garage_spaces = Convert.ToInt32(Console.ReadLine());

                DateTime time = DateTime.Now;
                Property newProperty = new Property(time.Ticks, suburb, street, price, bedrooms, bathrooms, garage_spaces);
                properties.Add(newProperty);

            }  else if (input == "2") {
                Console.WriteLine("Properties: ");
                foreach (Property p in properties) {
                    Console.WriteLine("######");
                    Console.WriteLine("ID: {0}\n", p.Id);  
                    Console.WriteLine("Suburb: {0}\n", p.Suburb);
                    Console.WriteLine("Street: {0}\n", p.Street);
                    Console.WriteLine("Price: {0}\n", p.Price);
                    Console.WriteLine("Bedroom Number: {0}\n", p.Num_bedroom);
                    Console.WriteLine("Bathroom Number: {0}\n", p.Num_bathroom);
                    Console.WriteLine("Garage Space Number: {0}\n", p.Num_garage);
                    Console.WriteLine("######");
                }
            } else if (input == "3") {
                Console.WriteLine("Enter a ID\n");
                double key = Convert.ToDouble(Console.ReadLine());
                Property returnedKey = properties.SingleOrDefault(r => r.Id == key) ?? throw new ArgumentNullException("String Values cannot be null, invalid format!\n");
                properties.Remove(returnedKey);
                Console.WriteLine("Removal Successful!\n");
            } else if (input == "4") {

            }
            string strJson = JsonSerializer.Serialize<List<Property>>(properties, new JsonSerializerOptions(){ WriteIndented=true });
            File.WriteAllText(@"example.json",strJson);

        }
    }
}