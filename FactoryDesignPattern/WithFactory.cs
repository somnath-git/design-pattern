

namespace FactoryDesignPattern
{
    public class WithFactory
    {
        public static void Main()
        {
            Console.WriteLine("select a network type");
            var networkType = Console.ReadLine()!;

            var socialNetwork = GetSocialNetworkInstance(networkType);

            socialNetwork.Like();
            socialNetwork.React();

        }

        private static ISocialNetwork GetSocialNetworkInstance(string networkType)
        {
            if(networkType == "facebook")
            {
                return new Facebook();
            }
            else if(networkType == "twitter")
            {
                return new Twitter();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
