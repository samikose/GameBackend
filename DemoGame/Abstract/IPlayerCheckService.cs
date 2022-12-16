using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
