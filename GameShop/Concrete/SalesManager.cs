using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class SalesManager : ISalesManager
    {

        public void CancelSale(ICustomer customer, ILoggerService loggerService)
        {
            Console.WriteLine("Sales Cancelled for customer: " + customer.FirstName);
            loggerService.Log();
        }

        public void Sell(ICustomer customer, IGame game, ICampaign campaign, ILoggerService loggerService)
        {
            Console.WriteLine("Sold to customer: " + customer.FirstName + " Game: " + game.EntityName + " with Campaign: " + campaign.EntityName);
            loggerService.Log();
        }
    }
}
