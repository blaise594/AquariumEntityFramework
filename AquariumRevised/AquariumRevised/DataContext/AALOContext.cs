using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquariumRevised.Models;

namespace AquariumRevised.DataContext
{
    class AALOContext :DbContext
    {
        public AALOContext():base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Ocean> Oceans { get; set; }
        public DbSet<Aquarium> Aquariums { get; set; }
        public DbSet<AquaticLife> AquaticLife { get; set; }
        public DbSet<AALO> AALO { get; set; }
         
    }
}
