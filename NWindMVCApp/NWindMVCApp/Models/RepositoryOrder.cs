//namespace NWindMVCApp.Models
//{
//    public class RepositoyOrder
//    {
//        public NorthwindContext _context;
//        public RepositoyOrder(NorthwindContext context)
//        {
//            _context = context;
//        }
//        public List<Order> GetAllOrderId()
//        {
//            return _context.Orders.ToList();
//        }
//        public Order PutOrder(int id)
//        {
//            Console.WriteLine($"searching id: {id}");
//            Order order = _context.Orders.Find(id);
//            return order;
//        }
//        public List<int> GetAllOrder()
//        {
//            return (from o in _context.OrderDetails select o.OrderId).ToList();
//        }
//    }
//}

namespace NWindMVCApp.Models
{
    public class RepositoyOrder
    {
        public NorthwindContext _context;
        public RepositoyOrder(NorthwindContext context)
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order PutOrder(int id)
        {
            Console.WriteLine($"searching id: {id}");
            Order order = _context.Orders.Find(id);
            return order;
        }
    }
    
