using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun kaldırıldı.");
        }
    }
}
