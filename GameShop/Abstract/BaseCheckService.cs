using GameShop.Concrete;
using GameShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public abstract class BaseCheckService : ICustomerCheckService
    {
        public abstract bool ValidateStudentOrAdult(ICustomer customer);
        public bool ValidatePerson(ICustomer customer)
        {
            //Mernis method
            return true;
            
        }



    }
}
