// 🛒 5. Produktinventering (Mini-Projekt)
// Skapa en klass Product med Name, Price, Category.
//  Bygg en lista av produkter och:
// Ta bort produkter under ett visst pris
// Gruppér produkterna efter kategori med LINQ .GroupBy()
// Sortera listan efter pris
//  💡 Extra: Kontrollera att alla priser är positiva med .All().

List<Product> products = new();
Product products1 = new Product { Name = "Tandborste", Price = 20, Category = "Badrum" };
Product products2 = new Product { Name = "ElTandborste", Price = 100, Category = "Badrum" };
Product products3 = new Product { Name = "Hushållspapper", Price = 80, Category = "Köket" };
Product products4 = new Product { Name = "Gräsklippare", Price = 1000, Category = "Trädgård" };
Product products5 = new Product { Name = "Fågelmat", Price = 50, Category = "Djur" };
Product products6 = new Product { Name = "Bits", Price = 50, Category = "Verktyg" };
Product products7 = new Product { Name = "Byrå", Price = 500, Category = "Sovrummet" };

products.Add(products1);
products.Add(products2);
products.Add(products3);
products.Add(products4);
products.Add(products5);
products.Add(products6);
products.Add(products7);

products.RemoveAll(product => product.Price < 100);

var groupedProducts = products.GroupBy(product => product.Category);
var sortedProducts = products.OrderBy(product => product.Price).ToList();
bool allPricesPositive = products.All(product => product.Price > 0);

Console.WriteLine("Sorterade produkter efter pris:");
foreach (var product in sortedProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price} kr - {product.Category}");
}

Console.WriteLine("\nGrupperade produkter efter kategori:");
foreach (var group in groupedProducts)
{
    Console.WriteLine($"\nKategori: {group.Key}");
    foreach (var product in group)
    {
        Console.WriteLine($"- {product.Name}: {product.Price} kr");
    }
}

Console.WriteLine($"\nAlla priser är positiva: {allPricesPositive}");

