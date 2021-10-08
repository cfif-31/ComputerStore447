using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore447.Types.Products
{
    public class Monitor:Product
    {
        public float Diagonal;

        public override void ShowInfo(User user)
        {
            base.ShowInfo(user);
            Console.WriteLine("Diagonal " + Diagonal);
        }

    }
}
