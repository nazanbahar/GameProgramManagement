using GameProgramManagementDemo.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    interface IGameService
    {
        void GameCreated();
        void GameDeleted();
        void GameSaved();
        void GameApproved();

    }
}
