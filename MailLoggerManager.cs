using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Concrete
{
    public class MailLoggerManager : ILoggerService
    {
        public void CustomerCreatedLog()
        {
            throw new NotImplementedException();
        }

        public void CustomerMadePreferredLog()
        {
            throw new NotImplementedException();
        }

        public void NewCampaign(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Notify(Game game)
        {
            throw new NotImplementedException();
        }

        public void OrderApprovedLog(Order order)
        {
            throw new NotImplementedException();
        }

        public void OrderCancelledLog(Order order)
        {
            throw new NotImplementedException();
        }

        public void OrderCreatedLog(Order order)
        {
            throw new NotImplementedException();
        }

        public void OrderUpdatedLog(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
