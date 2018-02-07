using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientBD.Entities.ReferenceTables;

namespace ClientBD.Entities
{
    class Production : Entity
    {
        public int Length { get; set; }
        public Rock ProductionRock { get; set; }
        public ProductionType Type { get; set; }
    }
}
