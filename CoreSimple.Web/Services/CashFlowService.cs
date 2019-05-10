using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSimple.Models;

namespace CoreSimple.Web.Services
{
    public class CashFlowService : ICashFlowService
    {
        public Task<int> AddAsync(CashFlow cashFlow)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlow>> GetCashFlowByDateAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<CashFlow> GetCurrentCashFlowAsync()
        {
            throw new NotImplementedException();
        }
    }
}
