using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Facebook : ISocialNetwork
    {
        public void Like()
        {
            Console.WriteLine("you have liked a post on facebook!");
        }

        public void React()
        {
            Console.WriteLine("you have reacted on facebook post!");
        }
    }
}
