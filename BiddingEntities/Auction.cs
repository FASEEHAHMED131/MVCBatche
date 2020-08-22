using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingEntities
{
   public class Auction
    {
        public int AuctionID { get; set; }
        public  string AuctionTitle { get; set; }
        public string AuctionImageUrl { get; set; }
        public string AuctionAmount { get; set; }
        public string AuctionDescription { get; set; }
        public DateTime BiddingStartTime { get; set; }
        public DateTime BiddingEndTime { get; set; }
        public string BiddingAmount { get; set; }
    }
}
