using GameShop.Concrete;
using GameShop.Abstract;
using GameShop.Adapters;
using GameShop.Entities;
using System;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer customer = new Student();
            ICustomer adult = new Adult() { Id = "12345", FirstName = "Sude", LastName = "Sude", BirthYear = 1983, StudentId = "8888" };
            ISignUpManager signUpManager = new SignUpManager(new StudentServiceAdapter());
            signUpManager.CustomerAdd(new Student { Id = "12345", FirstName = "Deniz", LastName = "Dinler", BirthYear = 2003, StudentId = "8888" });
            signUpManager.CustomerAdd(adult);

            ICampaignManager campaignManager = new CampaignManager();
            ICampaign campaign1 = new Campaign() { EntityName = "GAME25"};
            IGame game1 = new Game() { EntityName = "Doom2" };
            
            campaignManager.AddCampaign(campaign1,game1,adult);

            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(adult, game1, campaign1);
        }
    }
}
