using Anonymator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymator.Classes
{
    class DateMapping : Mapping
    {
        public bool IsPast { get; set; }
        public bool IsFuture { get; set; }
        
        public int Offset { get; set; }
        public DateOffsetUnit OffsetUnit { get; set; }

        public bool IsDateTime { get; set; }

        public override string GetSelectedOptions()
        {
            if (IsPast && IsFuture)
                return $" {"\u00B1"} {Offset} {OffsetUnit}";
            else if (IsFuture)
                return $" + {Offset} {OffsetUnit}";
            else if (IsPast)
                return $" - {Offset} {OffsetUnit}";
            else
                return "";
        }
    }
}
