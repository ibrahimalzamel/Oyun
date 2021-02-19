using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface ICampaingService
    {

        //bool NewCampaignEntry(GameSale gameSale);
       public void CampaignDelete(Campaing campaing);
       public void CampaignUpdate(Campaing campaing);
    }
}
