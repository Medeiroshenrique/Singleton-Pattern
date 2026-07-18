using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton WhithTheInstance = Singleton.Instance;
            WhithTheInstance.Message("I'm with the single instance!!!");

            Singleton OtherWhoGotTheInstance = Singleton.Instance;
            OtherWhoGotTheInstance.Message("Okay, I got the single instance!");

            Singleton ThirdWhoGotTheInstance = Singleton.Instance;
            ThirdWhoGotTheInstance.Message("I got it! The instance is with me! ");
        }
    }
}
