using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.EF
{
    public partial class Laptop : IAggregateRoot
    {
        public string Idlaptop { get; set; }
        public string Namelaptop { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string LinkImg { get; set; }
        public int? Count { get; set; }
        public string Idclassify { get; set; }
        public string Idtrademark { get; set; }
        public string Status { get; set; }
        public decimal? Priceselling { get; set; }

        public virtual Classify IdclassifyNavigation { get; set; }
        public virtual Trademark IdtrademarkNavigation { get; set; }
    }
}
