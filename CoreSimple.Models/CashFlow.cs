using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimple.Models
{
    public class CashFlow : ModelBase
    {
        /// <summary>
        /// 增加
        /// </summary>
        public decimal Increase { get; set; }
        /// <summary>
        /// 减少
        /// </summary>
        public decimal Reduce { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal Amount { get; set; }
    }
}
