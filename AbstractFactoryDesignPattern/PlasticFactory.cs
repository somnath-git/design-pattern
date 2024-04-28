using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class PlasticFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new PlasticChair();
        }
    }
}
