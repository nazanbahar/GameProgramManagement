using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public class ISalesService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Satışa % Kampanya eklendi...");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi...");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kayıt Edildi...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi...");
        }
    }
}
