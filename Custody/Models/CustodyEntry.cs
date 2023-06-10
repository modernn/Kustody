using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custody.Models
{
    public class CustodyEntry
    {
        public int ChildId { get; set; }
        public int ParentId { get; set; }
        public DateTime Date { get; set; }
    }

}
