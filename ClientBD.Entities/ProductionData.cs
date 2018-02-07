using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientBD.Entities.ReferenceTables;

namespace ClientBD.Entities
{
    class ProductionData : Entity
    {
        public Field ProductionDataField { get; set; }
        public Rock ProductionDataRock { get; set; }
        public int CaratNum { get; set; }
        public int CaratPrice { get; set; }
        public DateTime MineDate { get; set; }
    }
}
