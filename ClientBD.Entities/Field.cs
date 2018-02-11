using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientBD.Entities.ReferenceTables;

namespace ClientBD.Entities
{
    public class Field : Entity
    {
        public string Name { get; set; }
        public Country FieldCountry { get; set; }
        public int Year { get; set; }
        public PropertyType FieldPropertyType { get; set; }
        public Production FieldProduction { get; set; }
    }
}
