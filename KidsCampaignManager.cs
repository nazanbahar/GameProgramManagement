using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Concrete
{
    class KidsCampaignManager : ICampaignService
    {
        public void CampaignApproved()
        {
            throw new NotImplementedException();
        }

        public void CampaignCalculate(Campaign campaign)
        {
            Console.WriteLine("Kampanya %30 indirim oluşturuldu...");
        }

        public void CampaignCreated()
        {
            throw new NotImplementedException();
        }

        public void CampaignDeleted()
        {
            throw new NotImplementedException();
        }

        public void CampaignUpdated()
        {
            throw new NotImplementedException();
        }
    }
}
