using ComputerStore447.Types;
using ComputerStore447.Types.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore447
{
    class Program
    {
        static void Main(string[] args)
        {
           

            User user = new User { login = "ivan", password = "1234", name = "Ivanov Ivan", shopCount = 6 };

            List<Product> products = new List<Product>();
            Product product0 = new Product { Name = "Мышь компьютерная", price = 250.99m };
            Product product1 = new Product { Name = "Сканер Canon", price = 5762.20m };
            Monitor monitor = new Monitor { Name = "Philips 20d9", price = 16999.99m, Diagonal = 16.3f };

            products.Add(product0);
            products.Add(product1);
            products.Add(monitor);

            while (true)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    
                    products[i].ShowInfo(user);
                    Console.WriteLine("№"+i);
                }

                int tovarN = Convert.ToInt32(Console.ReadLine());
                Buy(user, products[tovarN]);
            }
        }

        static void Buy(User user, Product product) {
            user.shopCount++;
            Console.WriteLine("User:" + user.name +" "+ user.shopCount+  " buy Product "+ product.Name);
        }
    }
}
