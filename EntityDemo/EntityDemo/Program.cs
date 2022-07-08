using EntityDemo;
ProductDal productDal = new ProductDal();

#region Başlangıç Notlar
/*
 FIRS CODE
 https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
1. Entity Framework sitesinden uygun provider nugget olarak eklendi ve
            dotnet tool install --global dotnet-ef
2. DataAnnotations kullanarak Entity sınıfları oluşturuldu.
3. Context sınıfı oluşturuldu.
4. dotnet ef migrations add InitialCreate komutları ile Mirations dosyaları oluşturuldu
    dotnet ef database update  ve karşıya yükleme sağlandı
*/
#endregion

#region Add single entity
// var product = new Product { Name = "Iphone 11", Price = 2000 };
#endregion

#region Add entity with collection
/*
var products = new List<Product>()
{
    new Product(){Name = "Samsung S10",Price = 1500},
    new Product(){Name = "Xiaomi  Mi11 Lite",Price = 1750},
    new Product(){Name = "ReadMi",Price = 1500},
    new Product(){Name = "Iphone 13",Price = 2500},
};
productDal.addProducts(products);
*/
#endregion

#region Get All Items in Table
/*
 var products = productDal.GetProductsByName("Iphone");
 foreach (var p in products)
 {
     Console.WriteLine($"Product Name: {p.Name}  Price {p.Price} ");
 }
 #endregion

#region Remove Product
Product product = new Product() { Id = 4 };
productDal.RemoveProductsAsTracking(product);
*/
#endregion