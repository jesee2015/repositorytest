using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSimple.Models;
using CoreSimple.Web.DataBase;

namespace CoreSimple.Web.Services
{
    public class BillsItemService : IBillsItemService
    {
        public BillsItemService(MyDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public MyDbContext DbContext { get; }

        public int Add(BillsItem billsItem)
        {
            DbContext.BillsItems.Add(billsItem);
            return DbContext.SaveChanges();
        }

        public int Delete(int id)
        {
            var billsItem = GetById(id);
            DbContext.Remove(billsItem);
            return DbContext.SaveChanges();
        }

        //todo
        public int Edit(BillsItem billsItem)
        {
            GetById(billsItem.Id);
            return 0;
        }

        public IEnumerable<BillsItem> GetByDate(DateTime dateTime)
        {
            return DbContext.BillsItems.ToList();
        }

        public BillsItem GetById(int id)
        {
            return DbContext.BillsItems.FirstOrDefault(c => c.Id == id);
        }
    }
}
