using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
     //   List<Campaign> GetList();
    }
}
