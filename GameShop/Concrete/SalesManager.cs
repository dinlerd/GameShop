using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class SalesManager : ISalesManager
    {

        public void CancelSale(ICustomer customer)
        {
            Console.WriteLine("Sales Cancelled for customer: " + customer.FirstName);
        }

        public void Sell(ICustomer customer, IGame game, ICampaign campaign)
        {
            Console.WriteLine("Sold to customer: " + customer.FirstName + " Game: " + game.EntityName + " with Campaign: " + campaign.EntityName);
        }
    }
}
