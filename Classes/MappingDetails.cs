using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymator
{
    public class MappingDetails
    {

        private string _tableName;
        private List<Mapping> _mappings = new List<Mapping>();
        public MappingDetails(string tableName) 
        {
            _tableName = tableName;
        }

        public string TableName
        {
            get { return _tableName; }
        }

        public List<Mapping> Mappings
        { 
            get { return _mappings; }
        }

        public void AddMapping(Mapping mapping)
        {
            _mappings.Add(mapping);
        }
    }
}
