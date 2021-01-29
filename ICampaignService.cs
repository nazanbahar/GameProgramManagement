using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public interface ICampaignService
    {
        void CampaignCreated();
        void CampaignDeleted();
        void CampaignUpdated();
        void CampaignApproved();
 
        void CampaignCalculate(Campaign campaign);
        //List<Campaign> GetList();
    }
}
