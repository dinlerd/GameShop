using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    class SignUpManager : ISignUpManager
    {       
        private ICustomerCheckService _customerCheckService;
        
        public SignUpManager(BaseCheckService customerCheckService)
        {
            
            _customerCheckService = customerCheckService;
        }

        public void CustomerAdd(ICustomer customer, IDatabaseDal databaseDal)
        {
            if (_customerCheckService.ValidatePerson(customer))
            {
                if (_customerCheckService.ValidateStudentOrAdult(customer))
                {
                    Console.WriteLine(customer.FirstName + " saved as Student...");

                }
                else
                {
                    Console.WriteLine(customer.FirstName + " saved as Adult...");
                }
                databaseDal.Add();

            }
            else
            {
                Console.WriteLine("Customer is not a valid person. Please enter valid information.");
            }
        }

        public void CustomerUpdate(ICustomer customer, IDatabaseDal databaseDal)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " updated...");
            databaseDal.Update();
        }

        public void CustomerDelete(ICustomer customer, IDatabaseDal databaseDal)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " deleted...");
            databaseDal.Delete();
        }

    }
}
