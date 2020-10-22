using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymator.Classes
{
    public class NumericMapping : Mapping
    {
        public bool MatchSize { get; set; }
        public bool IsPercentage { get; set; }
        public int PercentageValue { get; set; }

        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public override String GetSelectedOptions()
        {
            
            if (MatchSize)
                return "Match Size";
            else if (IsPercentage)
                return $"{"\u00B1"} {PercentageValue}%";
            else
                return $"Range: {MinRange} - {MaxRange}";
        }
    }
}
