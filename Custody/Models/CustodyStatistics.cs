using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custody.Models
{
    public class CustodyStatistics
    {
        public int ParentId { get; set; }
        public double CustodyPercentage { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

}
