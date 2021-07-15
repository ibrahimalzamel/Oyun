using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
   public abstract class BaseCampaingManager : ICampaingService
    {
        public virtual void CampaignDelete(Campaing campaing)
        {
            Console.WriteLine();
        }


        public virtual void CampaignUpdate(Campaing campaing)
        {
            Console.WriteLine(" Kampanya Güncelledi");
        }
    }
}
