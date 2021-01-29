using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public interface IOrderService
    {
        void OrderCreated(Customer customer);
        void OrderCancelled(Customer customer);
        void OrderSaved(Customer customer);
        void OrderApproved(Customer customer);
        void OrderBuyNow(Customer customer);
        // void BuyNow(Player player, Product product, Campaign campaign);
    }
}
