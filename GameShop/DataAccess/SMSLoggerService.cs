using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.DataAccess
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS sent...");
        }
    }
}
