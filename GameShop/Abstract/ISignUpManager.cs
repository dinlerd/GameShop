using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    interface ISignUpManager
    {
        void CustomerAdd(ICustomer customer);
        void CustomerUpdate(ICustomer customer);
        void CustomerDelete(ICustomer customer);

    }
}
