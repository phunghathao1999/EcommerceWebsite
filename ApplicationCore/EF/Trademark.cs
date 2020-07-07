using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.EF
{
    public partial class Trademark : IAggregateRoot
    {
        public Trademark()
        {
            Laptop = new HashSet<Laptop>();
        }

        public string Idtrademark { get; set; }
        public string Trademark1 { get; set; }

        public virtual ICollection<Laptop> Laptop { get; set; }
    }
}
