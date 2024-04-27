using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Twitter : ISocialNetwork
    {
        public void Like()
        {
            Console.WriteLine("you have liked a twitter post !");
        }

        public void React()
        {
            Console.WriteLine("you have reacted on a twitter post!");
        }
    }
}
