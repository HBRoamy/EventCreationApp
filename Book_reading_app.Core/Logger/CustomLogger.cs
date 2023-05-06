using Book_reading_app.Core.Logger;
using System;

namespace Book_reading_app.Core
{
    public sealed class CustomLogger : ICustomLogger
    {
        private static CustomLogger _instance;
        private static int counterToVerifySingleton = 0;
        private CustomLogger()
        {
            counterToVerifySingleton++;
        }

        private static readonly object key = new object();

        public static CustomLogger GetInstance()
        {
            if(_instance==null)
            {

                lock(key)
                {
                    if(_instance==null)
                    {
                        _instance = new CustomLogger();
                    }
                }

            }
            return _instance;
        }

        public void LogToConsole(string info)
        {
            Console.WriteLine("*/----");
            Console.WriteLine("###Logged using Custom Logger : " + info );
            Console.WriteLine("counter value : " + counterToVerifySingleton);
            Console.WriteLine("----/*");

        }

    }
}
