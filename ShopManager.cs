using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Concrete
{
    public class ShopManager 
    {
        //Method injection
        public void KampanyaOlustur(ICampaignService campaignService, List<IProductService>productServices , List<ILoggerService>loggerServices) 
        {

            //Kampanya Bilgilerini Değerlendirme
            campaignService.CampaignCalculate();
            //campaignService.CampaignCreated();
            //campaignService.CampaignUpdated();
            //campaignService.CampaignUpdated();

            foreach (var loggerService in loggerServices)
            {
                loggerService.CustomerMadePreferredLog();

            }

            foreach (var productService in productServices)
            {
                productService.ProductCampaingn();

            }

        }

        //Kampanya Bilgilendirmesi
        public void KampanyaBilgilendir(List<ICampaignService> campaigns)
        {

            foreach (var campaign in campaigns)
            {
                campaign.CampaignCalculate();
            }
        }

        //Sipariş Ver
        public void SiparisVer(List<IOrderService> orders, List<IProductService> productServices)
        {

            foreach (var order in orders)
            {
                order.OrderBuyNow();
            }

        }

    }
}
