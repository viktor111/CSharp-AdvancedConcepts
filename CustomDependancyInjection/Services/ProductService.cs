using System;

namespace CustomDependancyInjection.Services
{
    public class ProductService
    {
        CartService _cartService;

        public ProductService(CartService cartService)
        {
            _cartService = cartService;
        }

        public void CreateProduct()
        {
            Console.WriteLine("Product created");
        }
    }
}
