using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.EF
{
    public partial class Cartdetail : IAggregateRoot
    {
        public string Idcartdetail { get; set; }
        public string Idcart { get; set; }
        public string Idproduct { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string Note { get; set; }

        public virtual Cart IdcartNavigation { get; set; }
    }
}
