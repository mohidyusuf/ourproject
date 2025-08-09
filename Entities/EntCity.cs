using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntCity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProvinceId { get; set; } // Link to Province
    }
}
