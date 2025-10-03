// See https://aka.ms/new-console-template for more information
using introEfCore.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

SampleDbContext sampleDbContext = new SampleDbContext();
var products = sampleDbContext.Products.Include(p => p.Category).ToList();
products.ForEach((p) => Console.WriteLine($"{p.Name}\t{p.Price}\t{p?.Category?.Name}"));
