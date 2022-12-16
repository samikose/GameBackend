using DemoGame.Abstract;
using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine("Game player saved : " + player.FirstName + " " +player.LastName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Game player deleted : " + player.FirstName + " " + player.LastName);
        }

        public void UpdateInfo(Player player)
        {
            Console.WriteLine("Game player updated : " + player.FirstName + " " + player.LastName);
        }
    }
}
