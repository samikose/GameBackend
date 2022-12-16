using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void Update(Campaigns campaign,double discountRate);
        void ApplyThisCampaign(Campaigns campaign,Products product);
    }
}
