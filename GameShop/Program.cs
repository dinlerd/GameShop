using GameShop.Concrete;
using GameShop.Abstract;
using GameShop.Adapters;
using GameShop.Entities;
using System;
using GameShop.DataAccess;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer customer = new Student();
            ICustomer adult = new Adult() { Id = "12345", FirstName = "Sude", LastName = "Sude", BirthYear = 1988, StudentId = "8888" };
            ISignUpManager signUpManager = new SignUpManager(new StudentServiceAdapter());
            signUpManager.CustomerAdd(new Student { Id = "12342153", FirstName = "Deniz", LastName = "Dinler", BirthYear = 2003, StudentId = "8888" }, new OracleServerDal());
            signUpManager.CustomerAdd(adult, new MySqlServerDal());

            ICampaignManager campaignManager = new CampaignManager();
            ICampaign campaign1 = new Campaign() { EntityName = "GAME25"};
            IGame game1 = new Game() { EntityName = "Doom2" };
            
            campaignManager.AddCampaign(campaign1,game1,adult, new MySqlServerDal());

            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(adult, game1, campaign1,new SMSLoggerService());
        }
    }
}
