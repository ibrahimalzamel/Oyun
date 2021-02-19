using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Adapters
{
   public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckService(Player player)
        {

            return true; 

        }
    }
}
