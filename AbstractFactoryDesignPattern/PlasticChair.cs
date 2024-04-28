using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class PlasticChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Hi ! I am plastic chair");
        }
    }
}
