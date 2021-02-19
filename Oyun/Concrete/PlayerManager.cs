using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public  class PlayerManager : BaseCustomerManager
    {

        ICustomerCheckService _customerCheckService;
        public PlayerManager (ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Player player)
        {
            if (_customerCheckService.CheckService(player))
            {
                Console.WriteLine("Doğrulama başarlı,Kayıt başarılı oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarsız,Kayıt başarsız ");
            }
        }

        public override void Delete(Player player)
        {
            Console.WriteLine("ID : " + player.Id + player.FirstName + " : Kayıt  Silendi ");
        }

        public override void Update(Player player)
        {
            Console.WriteLine("ID : " + player.Id + player.FirstName + " : Kayıt  Güncellendi ");
        }
    }
}
