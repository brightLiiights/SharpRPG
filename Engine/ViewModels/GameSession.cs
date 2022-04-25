using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player()
            {
                Name = "Alex",
                CharacterClass = "Fighter",
                HitPoints = 12,
                ExpPoints = 0,
                Level = 1,
                Gold = 1000000
            };
        }
    }
}
