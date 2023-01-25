using System;

namespace Carcassonne {

    class Program {
        static void Main(string[] args) {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Welcome to the Carcassonne Backend!");
            Property test = new Property("Randwick", "14 Botany Street", 400, 2, 2, 2);
            Console.WriteLine("The suburb is on {0} in {1}", test.Suburb, test.Street);
            Console.WriteLine("The property rents for ${0} a week and has {1} bedrooms, {2} bathrooms and {3} garage spaces", 
            test.Price, test.Num_bedroom, test.Num_bathroom, test.Num_garage);
            Console.WriteLine(test.Street);
        }
    }
}