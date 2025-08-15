using _15lab.extencions;
using _15lab.interfaces;
using _15lab.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15lab.Models
{
    internal class SurvivalGameApp : App, IMultiPlayer
    {


        public string Difficulty { get; set; }

        public int MaxPlayers { get; set; }
        bool IMultiPlayer.MaxPlayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SurvivalGameApp(string name, AppCategory category, double price, AppRating rating, string difficulty, int maxPlayers)
            : base(name, category, price, rating)
        {
            Difficulty = difficulty;
            MaxPlayers = maxPlayers;
        }

        public void StartMultiplayer()
        {
            Console.WriteLine($"Multiplayer GAME IS STARTED)");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine( " vaxt catmadi day ");
        }
    }
}


