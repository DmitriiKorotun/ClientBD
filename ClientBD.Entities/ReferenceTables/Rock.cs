using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Entities.ReferenceTables
{
    class Rock : ReferenceEntity
    {
        public RockType Type { get; set; }
    }
}
