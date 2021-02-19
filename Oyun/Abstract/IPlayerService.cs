using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface IPlayerService
    {

        public void Add(Player player);
        public void Update(Player player);
        public void Delete(Player player);

    }
}
