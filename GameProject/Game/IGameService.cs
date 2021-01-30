using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign);
    }
}
