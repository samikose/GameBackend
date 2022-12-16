using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Abstract
{
    public interface IPlayerService
    {
        void Register(Player player);
        void UpdateInfo(Player player);
        void DeleteAccount(Player player);

    }
}
