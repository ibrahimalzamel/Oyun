using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public abstract class  BaseCustomerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Added To DB : " + player.FirstName);

        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("Delete on DB : " + player.FirstName);

        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("Update To DB : " + player.FirstName);

        }
    }
}
