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

        public void CustomerAdd(ICustomer customer)
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

            }
            else
            {
                Console.WriteLine("Customer is not a valid person. Please enter valid information.");
            }
        }

        public void CustomerUpdate(ICustomer customer)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " updated...");
        }

        public void CustomerDelete(ICustomer customer)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " deleted...");
        }

    }
}
