using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimple.Models
{
    public class Account : ModelBase
    {
        public string LoginName { get; set; }
        public string Pwd { get; set; }
    }
}
