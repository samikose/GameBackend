using DemoGame.Abstract;
using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Info(Player player, Products product)
        {
            Console.WriteLine("Product: " + product.Name + " is sold to: " + player.FirstName + " with a price of: " + product.Price);
        }
    }
}