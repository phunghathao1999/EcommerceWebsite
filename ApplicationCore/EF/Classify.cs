using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.EF
{
    public partial class Classify : IAggregateRoot
    {
        public Classify()
        {
            Laptop = new HashSet<Laptop>();
        }

        public string Idclassify { get; set; }
        public string Nameclassify { get; set; }

        public virtual ICollection<Laptop> Laptop { get; set; }
    }
}
