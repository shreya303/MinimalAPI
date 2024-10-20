using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Minimal.Application.Services;
using Minimal.Core.Entities;

namespace MinimalAPI.Endpoints
{
    public static class ProductEndpoints // This should be a top-level static class
    {
        public static void MapProductEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/products", async (ProductService productService) =>
            {
                var products = await productService.GetAllProductsAsync();
                return Results.Ok(products);
            });

            routes.MapGet("/api/products/{id}", async (int id, ProductService productService) =>
            {
                var product = await productService.GetProductByIdAsync(id);
                return product is not null ? Results.Ok(product) : Results.NotFound();
            });

            routes.MapPost("/api/products", async (Product product, ProductService productService) =>
            {
                await productService.AddProductAsync(product);
                return Results.Created($"/api/products/{product.Id}", product);
            });

            routes.MapPut("/api/products/{id}", async (int id, Product product, ProductService productService) =>
            {
                var existingProduct = await productService.GetProductByIdAsync(id);
                if (existingProduct is null)
                    return Results.NotFound();

                await productService.UpdateProductAsync(product);
                return Results.Ok(product);
            });

            routes.MapDelete("/api/products/{id}", async (int id, ProductService productService) =>
            {
                await productService.DeleteProductAsync(id);
                return Results.NoContent();
            });
        }
    }
}
