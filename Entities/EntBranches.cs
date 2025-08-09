using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntBranches
    {
        public int BranchId { get; set; }
        public int NumberOfBranches { get; set; }

        public string? BranchName { get; set; }
        public string? BranchLocations { get; set; } // e.g., "Multan, Lahore"
        public string? BranchEmail { get; set; }
        public string? BranchPhone { get; set; }
    }
}
