

using Microsoft.AspNetCore.Mvc;
using NWindMVCApp.Models;



namespace NWindMVCApp.Controllers
{
    public class OrderController : Controller
    {
        private RepositoyOrder _context;
        public OrderController(RepositoyOrder context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Order> order = _context.GetOrders();
            return View(order);
        }
        public IActionResult Details(int id)
        {
            Order order = _context.PutOrder(id);
            return View(order);
        }
    }
}