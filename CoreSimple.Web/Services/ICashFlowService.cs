using CoreSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSimple.Web.Services
{
    public interface ICashFlowService
    {
        //获取现金流
        Task<IEnumerable<CashFlow>> GetCashFlowByDateAsync(DateTime dateTime);
        /// <summary>
        /// 获取最新的一条现金流
        /// </summary>
        /// <returns></returns>
        Task<CashFlow> GetCurrentCashFlowAsync();

        Task<int> AddAsync(CashFlow cashFlow);
        Task<int> DeleteAsync(int id);
    }
}
