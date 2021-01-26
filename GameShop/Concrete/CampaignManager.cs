using GameShop.Abstract;
using GameShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameShop.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void AddCampaign(ICampaign campaign, IGame game, ICustomer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " added for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }

        public void DeleteCampaign(ICampaign campaign, IGame game, ICustomer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " updated for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }

        public void UpdateCampaign(ICampaign campaign, IGame game, ICustomer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " deleted for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }
    }
}
