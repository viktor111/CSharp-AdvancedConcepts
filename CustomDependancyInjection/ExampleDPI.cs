using CustomDependancyInjection.DPI;
using CustomDependancyInjection.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDependancyInjection
{
    public class ExampleDPI
    {
        public static void ExampleOfDPI()
        {
            DependancyContainer container = new();

            container.AddTransient<CartService>();
            container.AddSingleton<ProductService>();
            container.AddSingleton<UserService>();
            

            DependancyResolver resolver = new(container);

            UserService userService = resolver.GetService<UserService>();
            userService.RegisterUser();

            ProductService productService = resolver.GetService<ProductService>();
            productService.CreateProduct();

            CartService cartService1 = resolver.GetService<CartService>();
            cartService1.AddToCart();

            CartService cartService2 = resolver.GetService<CartService>();
            cartService2.AddToCart();

            CartService cartService3 = resolver.GetService<CartService>();
            cartService3.AddToCart();
        }
    }
}
