// See https://aka.ms/new-console-template for more information
using Application;

Console.WriteLine("Hello, World!");



List<Product> GetProductsByPrice(decimal min, decimal max)
{
    var productService = new ProductService();
    var products = productService.GetProducts();

    var productsResult = new List<Product>();
    foreach (var product in products)
    {
        if (product.Price >= min && product.Price <= max)
        {
            productsResult.Add(product);
        }
    }

    return productsResult;
}

List<Product> GetProductsByPriceWithLinq(decimal min, decimal max)
{
    var productService = new ProductService();
    var products = productService.GetProducts();

    var productsResult = from product in products
                         where product.Price >= min && product.Price <= max                        
                         orderby product.Price
                         select product;

    return productsResult.ToList();
}

List<Product> GetProductsByPriceWithExtensionLinq(decimal min, decimal max)
{
    var productService = new ProductService();
    var products = productService.GetProducts();

    var productsResult = products.Where(p=>p.Price>min &&  p.Price <= max)
                                 .ToList();

    return productsResult;
}

void showProducts(List<Product> products)
{
    foreach (var product in products)
    {

        Console.WriteLine(product);
    }

    Console.WriteLine($"Toplam: {products.Count} ürün gösterildi ");
}

//var productsLessThen1000 = GetProductsByPrice(0, 1000);
//var productsBetween1000_1500 = GetProductsByPriceWithLinq(1000, 1500);
var productsBetween5000_7000 = GetProductsByPriceWithExtensionLinq(5000, 7000);
showProducts(productsBetween5000_7000);
