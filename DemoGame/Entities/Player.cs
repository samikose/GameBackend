using DemoGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Entities
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalId { get; set; }

    }
}
