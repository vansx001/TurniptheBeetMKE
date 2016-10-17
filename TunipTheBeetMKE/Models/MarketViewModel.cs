using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    [Serializable]
    public class MarketViewModel
    {
        public int Id { get; set; }
        public string marketname { get; set; }
        public string Schedule { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }
        public int ZipCode { get; set; }
        public List<Market> MarketList;


        //public Market()
        //{
        //    this.Id = Id;
        //    this.marketname = marketname;
        //    this.Schedule = Schedule;
        //    this.Address = Address;
        //    this.Products = Products;
        //    this.ZipCode = ZipCode;

        //}
    }
}