using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.EF
{
    public partial class Cart : IAggregateRoot
    {
        public Cart()
        {
            Cartdetail = new HashSet<Cartdetail>();
        }

        public string Idcart { get; set; }
        public DateTime? Createday { get; set; }
        public decimal? Totalprice { get; set; }
        public string Idaccount { get; set; }

        public virtual ICollection<Cartdetail> Cartdetail { get; set; }
    }
}
