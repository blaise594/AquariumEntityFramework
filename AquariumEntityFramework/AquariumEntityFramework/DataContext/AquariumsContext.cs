using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquariumEntityFramework.Models;

namespace AquariumEntityFramework.DataContext
{
    class AquariumsContext :DbContext
    {
        public AquariumsContext():base()
        {

        }

        public DbSet<Aquariums> Aquariumss { get; set; }
    }
}
