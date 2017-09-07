using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New.Domain.Entities
{
   public class part_nesting:part
    {
        public string note { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
