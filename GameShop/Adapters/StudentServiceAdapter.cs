using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Adapters
{
    class StudentServiceAdapter : BaseCheckService
    {
        public override bool ValidateStudentOrAdult(ICustomer customer)
        {
            if (customer.BirthYear > 2002 && !customer.StudentId.Equals(null) )
            {
                Console.WriteLine("Customer is a student...");
                return true;
            }
            else
            {
                Console.WriteLine("Customer is an adult...");
                return false;
            }
            
        }
    }
}
