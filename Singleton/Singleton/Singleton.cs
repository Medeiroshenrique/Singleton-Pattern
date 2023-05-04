using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Single instance created.");
                    Console.ResetColor();
                }
                    

                return instance;
            }
        }

        public void Message(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

    }
}