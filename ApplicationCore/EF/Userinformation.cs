using ApplicationCore.Interfaces;

namespace ApplicationCore.EF
{
    public partial class Userinformation : IAggregateRoot
    {
        public string IdUser { get; set; }
        public string NameUser { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? Numberphone { get; set; }
    }
}