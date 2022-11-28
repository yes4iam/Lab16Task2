using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Task_2
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
            Product maxPrice = products[0];
            foreach (Product e in products)
            {
                if (e.Price > maxPrice.Price)
                {
                    maxPrice = e;
                }

            }
            Console.WriteLine($"Самый дорогой товар: {maxPrice.Code}, {maxPrice.Name}, {maxPrice.Price}");
            Console.ReadKey();
        }
    }
}
