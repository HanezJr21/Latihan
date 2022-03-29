using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Latihan.Interface;
using Latihan.Models;
using Microsoft.Extensions.Logging;

namespace Latihan.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IMenu _menu;

        public OrderController(ILogger<OrderController> logger, IMenu menu)
        {
            _logger = logger;
            _menu = menu;
;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetMenuList()
        {
            var response = new List<Menu>();
            try
            {
                response = _menu.GetMenuList();
            }
            catch (Exception ex)
            {
                response = null;
                _logger.LogError(ex.Message);
            }
            return Json(response);
        }
    }
}
