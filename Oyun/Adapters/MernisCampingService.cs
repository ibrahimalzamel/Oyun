using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Adapters
{
    public class MernisCampingService : ICampaingService
    {
        public void CampaignDelete(Campaing campaing)
        {
            Console.WriteLine("ID : " + campaing.Id + campaing.FirstName + " : Kampanya Silindi");
        }

        public void CampaignUpdate(Campaing campaing)
        {
            Console.WriteLine("ID : " + campaing.Id + campaing.FirstName + " : Kampanya  Güncelledi");
        }
    }
}
