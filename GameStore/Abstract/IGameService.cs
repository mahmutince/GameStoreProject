using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
