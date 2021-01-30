using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.Name + " game has been sold to player that name is " + gamer.FirstName + " " + gamer.LastName + 
                " with " + campaign.Name + " campaign");
        }
    }
}
