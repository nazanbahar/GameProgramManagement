using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Entitties
{
    public class Game
    {
        //GameId, GameCode ,  GameName, Hardware, GameDescription, TechnicalSupport
        public int GameId { get; set; }
        public int GameCode { get; set; }
        public string GameName { get; set; }
        public string Hardware { get; set; }
        public string TechnicalSupport { get; set; }

    }
}
