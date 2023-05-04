using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton WhithTheInstance = Singleton.GetInstance;
            WhithTheInstance.Message("I'm with the single instance!!!");

            Singleton OtherWhoGotTheInstance = Singleton.GetInstance;
            OtherWhoGotTheInstance.Message("Okay, I got the single instance!");

            Singleton ThirdWhoGotTheInstance = Singleton.GetInstance;
            ThirdWhoGotTheInstance.Message("I got it! The instance is with me! ");
        }
    }
}