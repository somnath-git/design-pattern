using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class WithoutFactory
    {
        public static void Main()
        {
            Console.WriteLine("select a network type");
            var networkType = Console.ReadLine();

            Facebook facebook = null;
            Twitter twitter = null;
            if(networkType == "facebook")
            {
                facebook = new Facebook();
                facebook.Like();
            }
            else
            {
                twitter = new Twitter();
                twitter.Like();
            }

            //for React again condition check

            if(networkType == "facebook")
            {
                facebook!.React();
            }
            else
            {
                twitter!.React();
            }

            Console.ReadKey();
        }
    }
}
