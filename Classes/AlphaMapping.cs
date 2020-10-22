using Anonymator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymator.Classes
{
    public class AlphaMapping : Mapping
    {
        public AlphaOptions SelectedOption { get; set; }

        public override String GetSelectedOptions() 
        {
            return SelectedOption.ToString();
        }
    }
}
