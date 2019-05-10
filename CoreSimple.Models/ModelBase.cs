using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimple.Models
{
    public abstract class ModelBase
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
