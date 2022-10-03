using ShopProduct.Models;

namespace ShopProduct.Services;

public static class ProductService {
     static List<Product> Products { get; }
     static int nextId = 3;
     static ProductService() {
        Products = new List<Product> {
            new Product { Id = 0001, Name = "T Shirt", Description = "Lorem Ipsum quick brown fox jumps over the lazy dog.", 
                
                    Quantity = 50,
                    Price = 120,
                    Color = "Gray",
                    Size = "small",
                    Images = new List<string>() {
                        "image1","image2"
                    }

                },
            new Product { Id = 0002, Name = "Short Pants", Description = "A quick brown fox jumps over the lazy dog.", 
                Quantity = 50,
                Price = 120,
                Color = "gray",
                Size = "medium",
                Images = new List<string>() {
                        "image1","image2","image3"
                }

              }
        };
     }

     public static List<Product> GetAll() => Products;
}