namespace Order.Models{
    public class Orders
    {
        private readonly List<OrderInfo> _orders;

        public Orders()
        {
            _orders = new List<OrderInfo>();
        }
        
        public void AddOrder(OrderInfo order){
            _orders.Add(order);
        }
    }

    public class OrderInfo
    {
        public string name { get; set; }
        public string product { get; set; }
    }
}

