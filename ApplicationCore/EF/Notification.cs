using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.EF
{
    public partial class Notification : IAggregateRoot
    {
        public string Idnotification { get; set; }
        public int? Idaccount { get; set; }
        public string Content { get; set; }
    }
}
