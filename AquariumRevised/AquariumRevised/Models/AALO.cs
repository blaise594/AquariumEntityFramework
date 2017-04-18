using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumRevised.Models
{
    class AALO
    {
        public int Id { get; set; }

        public int AquariumId { get; set; }
        public Aquarium Aquarium { get; set; }

        public int AquaticLifeId { get; set; }
        public AquaticLife AquaticLife { get; set; }

        public int OceanId { get; set; }
        public Ocean Ocean {get; set;}
    }
}
