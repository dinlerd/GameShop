using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.DataAccess
{
    public class MySqlServerDal : IDatabaseDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL added." ); 
        }

        public void Delete()
        {
            Console.WriteLine("MySQL deleted.");
        }

        public void Update()
        {
            Console.WriteLine("MySQL updated.");
        }
    }
}
