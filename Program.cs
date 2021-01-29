using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Adapters;
using GameProgramManagementDemo.Concrete;
using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;

namespace GameProgramManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            //mernis sadece doğum yılını kontrol ediyor.
            BaseCustomerManager customerManager = new PersonCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer
            {
                NationalityId = 65903045602,
                FirstName = "Can",
                LastName = "Bahar",
                DateOfBirthYear = 2010
            });


            KidsProductManager kidsProduct1 = new KidsProductManager();

            kidsProduct1.ProductSaved
                (new Product
                {
                    ProductId = 01,
                    ProductName = "Kids Store Game",
                    ProductPrice = 129.99,
                });

            KidsProductManager kidsProduct2 = new KidsProductManager();
            kidsProduct2.ProductSaved
                (new Product
                {
                    ProductId = 02,
                    ProductName = "Kids Mindmap",
                    ProductPrice = 78.99,
                });



            //campaign
            KidsCampaignManager kidscampaign = new KidsCampaignManager();
            kidscampaign.CampaignCalculate
            (new Campaign
            {
                CampaignId = 02,
                CampaignName = "Kids Mindmap",
                PercentValue = 5,
            });

            kidscampaign.CampaignCalculate
            (new Campaign
            {
                CampaignId = 03,
                CampaignName = "Kids Intelligence ",
                PercentValue = 10,
            });



            //player
            KidsPlayerManager kidsPlayer1 = new KidsPlayerManager();
            kidsplayer1.PlayerCreated
            (new Player
            {
                PlayerId = 01,
                PlayingName = "KIDS-Ezgi",
                JoinYear = 2020,
                Rank = 0,
            });
  



            ///      son code.......
            List<ILoggerService> loggers = new List<ILoggerService> { new MailLoggerManager() };
            List<ICampaignService> campaings = new List<ICampaignService> { new BaseCampaignManager(), new KidsCampaignManager() };

            ShopManager shopManager = new ShopManager();
            shopManager.KampanyaOlustur(new KidsCampaignManager(), kidsProduct1,loggers);
            shopManager.KampanyaBilgilendir(new KidsCampaignManager(), kidsProduct2, loggers);
            shopManager.SiparisVer(customerManager,kidsProduct1);
            shopManager.BuyNow(campaings);






        }
    }
}
