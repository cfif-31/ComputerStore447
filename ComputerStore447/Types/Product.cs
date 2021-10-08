using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore447.Types
{
    public class Product
    {
        public string Name;
        public decimal price;

        public virtual void ShowInfo(User user) {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine(Name);
            Console.WriteLine(GetPrice(user));
        }

        public decimal GetPrice(User user) {
            if (user.shopCount >= 10)
                return (price / 100) * 90;
            return price;
        }
    }
}
