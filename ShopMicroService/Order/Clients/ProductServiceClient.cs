using Product.Models;

public class ProductServiceClient
{
    private readonly HttpClient _httpClient;

    public ProductServiceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductInfo>?> GetProducts()
    {
        var response = await _httpClient.GetAsync("/api/App/products");

        if (response.IsSuccessStatusCode)
        {
            var products = await response.Content.ReadFromJsonAsync<List<ProductInfo>>();
            Console.WriteLine("hello"+ products);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            return products;
        }
        
        return null;
    }
}