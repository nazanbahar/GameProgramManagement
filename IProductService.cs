using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public interface IProductService
    {
        void ProductCreated(Product product);
        void ProductDeleted(Product product);
        void ProductSaved(Product product);
        void ProductApproved(Product product);
        void ProductCampaingn(Product product);
    }
}
