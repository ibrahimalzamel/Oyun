using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
   public class GameManager : IGameSaleService
    {

        ICampaingService _campaingService; 

        public GameManager (ICampaingService campaingService)
        {
            _campaingService = campaingService; 

        }

        public void GetGameSale(GameSale gameSale)
        {
            Console.WriteLine("Oyun Satın Aldıı"); 
        }
    }
}
