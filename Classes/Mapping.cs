using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anonymator.Classes;

namespace Anonymator
{
    public class Mapping
    {
        public ColumnDetails Column { get; set; }
        public Anonymizers Anonymiser { get; set; }

        public virtual String GetSelectedOptions()
        {
            return string.Empty;
        }
    }
}
