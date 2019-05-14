using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IT_Lab3.Models
{
    public class FriendDB : DbContext
    {
        public FriendDB () : base("FriendDB")
        {

        }
        public DbSet<FriendModel> FriendModels { get; set; }

    }
}