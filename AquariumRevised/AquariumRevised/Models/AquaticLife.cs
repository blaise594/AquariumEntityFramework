using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumRevised.Models
{
    class AquaticLife
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool ISinQuarantine { get; set; }
        public DateTime DateAddedToTank
        {
            get
            {
                return this.dateAddedToTank.HasValue
                    ? this.dateAddedToTank.Value
                    : DateTime.Now;
            }
            set { this.dateAddedToTank = value; }
        }
        private DateTime? dateAddedToTank = null;
    }
}
