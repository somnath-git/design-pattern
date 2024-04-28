using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class WoodenFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new WoodenChair();
        }
    }
}
