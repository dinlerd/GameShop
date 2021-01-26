using GameShop.Concrete;
using GameShop.Entities;
using ServiceReference1;
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
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.Id), customer.FirstName, customer.LastName, customer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;


        }



    }
}
