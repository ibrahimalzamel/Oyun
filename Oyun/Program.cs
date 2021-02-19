using Oyun.Abstract;
using Oyun.Adapters;
using Oyun.Concrete;
using Oyun.Entities;
using System;

namespace Oyun
{
    class Program
    {
        //1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
        //     Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
        //     (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)
        //2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
        //      (Yapılan satışlar oyuncu ile ilişkilendirilmelidir.Oyuncunun parametre olarak metotta olmasını kastediyorum.)
        //3. Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
        //4.Satışlarda kampanya entegrasyonunu simule ediniz.

        static void Main(string[] args)
        {
           


            BaseCustomerManager playerCustomerManager = new PlayerManager(new MernisServiceAdapter());
            playerCustomerManager.Add(new Player
            {
                Id = 1,
                FirstName = "İbrahim",
                LastName = "alzamel",
                Birthyear = new DateTime(1996, 3, 11),
                NationalyId = 123456789,
            }); 
            
            playerCustomerManager.Update(new Player
            {
                Id = 1,
                FirstName = "İbrahim",
                LastName = "alzamel",
                Birthyear = new DateTime(1996, 3, 11),
                NationalyId = 123456789,
            });

            playerCustomerManager.Delete(new Player
            {
                Id = 1,
                FirstName = "İbrahim",
                LastName = "alzamel",
                Birthyear = new DateTime(1996, 3, 11),
                NationalyId = 123456789,
            });

            BaseCampaingManager campaingManager = new CampaingManager(new MernisCampingService());

            campaingManager.CampaignUpdate(new Campaing { Id = 1, FirstName = "101 Campign" });
            campaingManager.CampaignDelete(new Campaing { Id = 1, FirstName = "101 Campign" });

            GameManager gameManager = new GameManager(new MernisCampingService());
            gameManager.GetGameSale(new GameSale());



        }
    }
}
