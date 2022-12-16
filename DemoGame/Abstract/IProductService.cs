using DemoGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Abstract
{
    public interface IProductService
    {
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
    }
}
