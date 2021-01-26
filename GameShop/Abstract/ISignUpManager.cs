using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    interface ISignUpManager
    {
        void CustomerAdd(ICustomer customer, IDatabaseDal databaseDal);
        void CustomerUpdate(ICustomer customer, IDatabaseDal databaseDal);
        void CustomerDelete(ICustomer customer, IDatabaseDal databaseDal);

    }
}
