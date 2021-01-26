using GameShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface ICampaignManager
    {
        void AddCampaign(ICampaign campaign, IGame game, ICustomer customer,IDatabaseDal databaseDal);
        void UpdateCampaign(ICampaign campaign, IGame game, ICustomer customer, IDatabaseDal databaseDal);
        void DeleteCampaign(ICampaign campaign, IGame game, ICustomer customer, IDatabaseDal databaseDal);

    }
}
