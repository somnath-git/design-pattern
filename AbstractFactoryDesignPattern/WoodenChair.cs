using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class WoodenChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("I am wooden chair");
        }
    }
}
