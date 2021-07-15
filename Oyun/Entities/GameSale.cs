using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Entities
{
    public class GameSale : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
