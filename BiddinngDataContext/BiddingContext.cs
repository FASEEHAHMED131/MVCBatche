using BiddingEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddinngDataContext
{
    class BiddingContext : DbContext
    {
        public BiddingContext() : base("name=BiddingContext")
        {
            
        }
        public DbSet<Auction> auctions { get; set; }
    }
}
