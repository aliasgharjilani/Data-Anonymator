using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymator
{
    public class ColumnDetails
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public float Size { get; set; }
        public bool Nullable { get; set; }
        public bool IsPK { get; set; } 
    }
}
