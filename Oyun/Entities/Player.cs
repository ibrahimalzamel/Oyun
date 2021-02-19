using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalyId { get; set; }
        public DateTime Birthyear { get; set; }

    }
}
