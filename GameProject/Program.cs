using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args) 
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { NationalID = ..., FirstName = "Uğur", LastName = "Yazgan", BirthYear = 1996});

            Campaign campaign1 = new Campaign { Name = "The boss must be crazy !", AdFlight = "03-03-2021" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            GameManager gameSellManager = new GameManager();
            gameSellManager.Sell(new Game { Name = "Crusader Kings 3" }, new Gamer { FirstName = "Uğur", LastName = "Yazgan" },
                campaign1);
        }
    }
}
