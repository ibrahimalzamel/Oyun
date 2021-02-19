using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
   public class CampaingManager : BaseCampaingManager
    {

        ICampaingService _campaingService; 
        public  CampaingManager(ICampaingService campaingService)
        {
            _campaingService = campaingService;
        }
        public override void CampaignDelete(Campaing campaing)
        {
            Console.WriteLine("ID : " + campaing.Id + campaing.FirstName + " : Kampanya Silindi");
        }

        public override void CampaignUpdate(Campaing campaing)
        {
            Console.WriteLine("ID : " + campaing.Id + campaing.FirstName + " : Kampanya Güncellendi");
        }

       
    }
}
