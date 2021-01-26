using GameShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface ICustomerCheckService
    {
        bool ValidatePerson(ICustomer customer);
        bool ValidateStudentOrAdult(ICustomer customer);

    }
}
