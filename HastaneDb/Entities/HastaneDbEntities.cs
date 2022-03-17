using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
   public class HastaneDbEntities : DbContext
    {
        public HastaneDbEntities()
        {
            this.Database.Connection.ConnectionString = @"Server=DESKTOP-5P4QE71\SQLEXPRESS;Database=HastaneDb5;Trusted_Connection=True;";
        }
        public DbSet<AileHekimleri> AileHekimleris { get; set; }
        public DbSet<Hastalar> Hastalars { get; set; }
        public DbSet<Hastaliklar> Hastaliklars { get; set; }
        public DbSet<Muayeneler> Muayenelers { get; set; }
        public DbSet<MuayeneHastaliklar> MuayeneHastaliklars { get; set; }
    }
}
