using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Concrete
{
    public class KidsPlayerManager : IPlayerService
    {
        public void PlayerApproved()
        {
            throw new NotImplementedException();
        }

        public void PlayerCreated()
        {
            Console.WriteLine("Kid Player eklendi....");
        }

        public void PlayerDeleted()
        {
            throw new NotImplementedException();
        }

        public void PlayerSaved()
        {
            throw new NotImplementedException();
        }
    }
}

