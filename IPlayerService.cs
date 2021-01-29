using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public interface IPlayerService
    {
        void PlayerCreated();
        void PlayerDeleted();
        void PlayerSaved();
        void PlayerApproved();
    }
}
