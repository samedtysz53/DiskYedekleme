using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiskYedekleme.Models
{
    public class DBcontext:DbContext
    {

        public DBcontext():base("Connection") 
        {
        
        }

        public DbSet<Users> Users { get; set; }

    }
}