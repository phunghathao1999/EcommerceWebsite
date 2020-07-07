using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
namespace ApplicationCore.EF
{
    public partial class Complain : IAggregateRoot
    {
        public string Idcomplain { get; set; }
        public string Idaccount { get; set; }
        public string Idcartdetail { get; set; }
        public DateTime? Createday { get; set; }
        public string Status { get; set; }
    }
}
