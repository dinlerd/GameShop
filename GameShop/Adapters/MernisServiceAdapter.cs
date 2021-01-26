using GameShop.Abstract;
using GameShop.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Adapters
{
    class MernisServiceAdapter : BaseCheckService
    {
        public override bool ValidateStudentOrAdult(ICustomer customer)
        {
            Console.WriteLine("Search by name and lastname in anaother system");
            return true;
            
        }
    }
}
