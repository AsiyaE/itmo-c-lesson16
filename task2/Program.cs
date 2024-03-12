using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product theMostExpensive = products[0];

            foreach (Product p in products)
            {
                if (p.Price> theMostExpensive.Price)
                {
                    theMostExpensive = p;
                }
            }

            Console.WriteLine($"Самый дорогой товар: {theMostExpensive.Name} - {theMostExpensive.Price} р") ;
            Console.ReadKey();
        }
    }
}
