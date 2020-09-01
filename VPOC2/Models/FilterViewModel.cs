using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPOC2.Models
{
    public class FilterViewModel
    {
        public string Name { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
