using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custody.Models
{
    public class DashboardData
    {
        public List<Child> Children { get; set; }
        public List<Parent> Parents { get; set; }
        public List<CustodyEntry> CustodyEntries { get; set; }
        public List<CustodyStatistics> CustodyStatistics { get; set; }
    }

}
