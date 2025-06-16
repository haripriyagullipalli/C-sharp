using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc;
using Order.Models;

[ApiController]
[Route("[controller]")]
public class AppController:Controller
{
   // private readonly Orders _oders;
   private readonly UserServiceClient _userServiceClient;
   private readonly ProductServiceClient _productServiceClient;
   private readonly Orders _orders;

   public AppController(UserServiceClient userServiceClient, ProductServiceClient productServiceClient, Orders orders)
   {
      _userServiceClient = userServiceClient; 
      _productServiceClient = productServiceClient;
      _orders = orders;
   }
   
   [HttpPost("order")]
   public async Task<IActionResult> Order([FromBody] OrderInfo order)
   {
      var users = await  _userServiceClient.GetUsers();
      Console.WriteLine("jdksfsljdfdlskf"+ users);
      
      var products = await _productServiceClient.GetProducts();
      Console.WriteLine("products are" + products);
      if (products != null)
      {
         foreach (var product in products)
         {
            Console.WriteLine(product);
         }

         bool isProductExist = products.Any((x) => x?.Name == order.product);

         if (isProductExist)
         {
            _orders.AddOrder(order);
            return Ok("order confirmed");
         }
      }


      return Ok("product not available");
   }
}