using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.DataAccess
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
