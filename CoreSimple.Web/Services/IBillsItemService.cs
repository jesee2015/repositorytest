using CoreSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSimple.Web.Services
{
    public interface IBillsItemService
    {
        IEnumerable<BillsItem> GetByDate(DateTime dateTime);
        BillsItem GetById(int id);
        int Add(BillsItem billsItem);
        int Edit(BillsItem billsItem);
        int Delete(int id);
    }
}
