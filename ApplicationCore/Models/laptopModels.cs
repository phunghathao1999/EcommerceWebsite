using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ApplicationCore.Models
{
    public class laptopModels
    {
        //public productModels(int Idproduct, string Nameproduct, string Description, decimal? Price, string LinkImg, int? Count, string Trademark, int? Idclassify, int? Idmanufacturer)
        //{
        //    this.Idproduct = Idproduct;
        //    this.Nameproduct = Nameproduct;
        //    this.Description = Description;
        //    this.Price = Price;
        //    this.LinkImg = LinkImg;
        //    this.Count = Count;
        //    this.Trademark = Trademark;
        //    this.Idmanufacturer = Idmanufacturer;
        //    this.Idclassify = Idclassify;
        //}
        public string Idproduct { get; set; }
        public string Nameproduct { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string image { get; set; }
        public int? Count { get; set; }
        public string Idclassify { get; set; }
        public string Idmanufacturer { get; set; }
        public string Trademark { get; set; }
        public decimal? Priceselling { get; set; }
        public string Status { get; set; }
    }
}
