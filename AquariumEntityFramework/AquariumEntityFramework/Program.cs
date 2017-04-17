using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquariumEntityFramework.DataContext;
using AquariumEntityFramework.Models;

namespace AquariumEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AquariumsContext();

            // SELECT * FROM Aquariumss
            var AllAquariums = db.Aquariumss.ToList();

            //CREATE!
            var aquarium = new Aquariums
            {
                Name = "Tennessee Aquarium",
                City = "Chatanooga"
            };

            db.Aquariumss.Add(aquarium);
            db.SaveChanges();


        }
    }
}
