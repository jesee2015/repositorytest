using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimple.Models
{
    public class BillsItem : ModelBase
    {
        public string Market { get; set; }
        public string Shop { get; set; }
        public string ProductNoName { get; set; }
        public int ProductNumber { get; set; }

    }
}
