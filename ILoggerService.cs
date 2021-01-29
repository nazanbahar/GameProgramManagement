using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///  imza - şablon
/// </summary>
namespace GameProgramManagementDemo.Abstract
{
    public interface ILoggerService
    {
         //order
        void OrderCreatedLog(Order order);
        void OrderCancelledLog(Order order);
        void OrderSavedLog(Order order);
        void OrderApprovedLog(Order order);
        //customer
        void CustomerCreatedLog();
        void CustomerMadePreferredLog();
        //other
        void Notify(Game game);
        //campaign
        void NewCampaign(Campaign campaign);
    }
}
