using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateATownWithClass
{
    class School
    {
        public string PropertyName { get; set; }
        public string BuildingType { get; set; }

        public string DisplayName()
        {
            return this.PropertyName;
        }

        public override string ToString()
        {
            return ($"{BuildingType} : {PropertyName}");

        }

    }
}
