namespace Product.Models
{
    public class Products
    {
        private readonly List<ProductInfo> _products;

        public Products()
        {
            _products = new List<ProductInfo>();
        }
    
        public List<ProductInfo> GetProducts => _products;

        public string AddProduct(ProductInfo product)
        {
            _products.Add(product);
            return "Product added";
        }
    }

    public class ProductInfo
    {
        public string Name { get; set; }
        public int price{ get; set; }
    }
}
