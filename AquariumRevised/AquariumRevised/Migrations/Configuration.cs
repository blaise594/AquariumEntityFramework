namespace AquariumRevised.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AquariumRevised.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AquariumRevised.DataContext.AALOContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AquariumRevised.DataContext.AALOContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var oceans = new List<Ocean>
            {
                new Ocean{Name = "Atlantic", AverageTemperature = 57},
                new Ocean{Name = "Pacific", AverageTemperature = 42},
                new Ocean{Name = "Indian", AverageTemperature = 77},
                new Ocean{Name = "Arctic", AverageTemperature = 29}

            };

            oceans.ForEach(oc => context.Oceans.AddOrUpdate(o => o.Name, oc));
            context.SaveChanges();

            var creatures = new List<AquaticLife>
            {
                new AquaticLife{Name = "Winter", Type = "Dolphin", Color = "Grey"},
                new AquaticLife{Name = "Fin", Type = "Shark", Color = "Blue"},
                new AquaticLife{Name = "Nemo", Type = "Fish", Color = "Orange"},
                new AquaticLife{Name = "Dory", Type = "Fish", Color = "Blue"}
            };
            creatures.ForEach(creature => context.AquaticLife.AddOrUpdate(c => c.Type, creature));

            var places = new List<Aquarium>
            {
                new Aquarium {Name = "Shedd Aquarium", City = "Chicago"},
                new Aquarium {Name = "Georgia Aquarium", City = "Atlanta"},
                new Aquarium {Name = "National Aquarium", City = "Baltimore"},
                new Aquarium {Name = "Tennesssee Aquarium", City = "Chatanooga"}
            };

            places.ForEach(place => context.Aquariums.AddOrUpdate(p => p.Name, city));
            context.SaveChanges();
        }
    }
}
