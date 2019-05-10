using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSimple.Models;
using CoreSimple.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreSimple.Web.Controllers
{
    public class BillsItemController : Controller
    {
        public BillsItemController(IBillsItemService billsItemService)
        {
            BillsItemService = billsItemService;
        }

        public IBillsItemService BillsItemService { get; }

        public IActionResult Index()
        {
            return Content("welcome to liulurong!");
        }

        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                var billsItem = BillsItemService.GetById(id);
                return Json(billsItem);
            }
            return Json("id error");
        }
         
        public IActionResult GetByDate(DateTime dateTime)
        {
            if (dateTime != null)
            {
                var billsItems = BillsItemService.GetByDate(dateTime);
                return Json(billsItems);
            }
            return Json("dateTime error");
        }

        public IActionResult Add(BillsItem billsItem)
        {
            if (ModelState.IsValid)
            {
                var res = BillsItemService.Add(billsItem);
                return Json(new { code = res });
            }
            return Json(new { code = -1 });
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var res = BillsItemService.Delete(id);
                return Json(new { code = res });
            }
            return Json(new { code = -1 });
        }
    }
}