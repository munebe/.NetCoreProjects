using Microsoft.EntityFrameworkCore;

namespace EntityDemo;

public class ProductDal
{
    #region Add Methods
    public void addProduct(Product product)
    {
        using (var db = new ShopContext())
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
    public void addProducts(List<Product> products)
    {
        using (var db=new ShopContext())
        {
            db.AddRange(products);
            db.SaveChanges();
            Console.WriteLine("Kayıt tamamlandı");
        }
    }
    

    #endregion

    #region Get Methods

    #region GetAllProducts
    public List<Product> GetAllProducts()
    {
     
        using (var db=new ShopContext())
        {
            var products = db
                .Products
                //todo sor
                //.Select(x => new { x.Id,x.Name,x.Price}) //bu yapı ile kolon verilebilir.
                .Where(x=>x.Id==1)
                .ToList();
            /* Burada ToList yerine "First" veya "FirstOrDefault" kullanılabilir
             First: Bulduğu ilk kaydı getirir
             FirstOrDefault: Bir kayıt bulamaz ise null döndürür
             Not: ToList kulanıldığı zaman collection döndürür
             */
            
            return products;
        }
    }
    #endregion
    

    #region GetProductById
    public Product GetProductById(int id)
    {
        using (var db=new ShopContext())
        {
            Product product = db.Products
                .Where(x=>x.Id==id)
                .FirstOrDefault();
            return product;
        }
    }
    #endregion
    #region GetProductsByName
    public List<Product> GetProductsByName(string name)
    {
        using (var db=new ShopContext())
        {
            List <Product> products= db.Products
                .Where(x => x.Name.Contains(name))
                .ToList();
            return products;
        }
    }
    #endregion
   
#endregion

    #region Update Methods
public void UpdateProductAsTracking()
{
    using (var db=new ShopContext())
    {
        var p = db.Products
            .Where(p => p.Id == 1)
            .AsNoTracking()// bu parametre kapalı ise izleme kapanır ve sadece select çalışır
            .FirstOrDefault();
        if (p != null)
        {
            p.Price *= 1.2m; //decimal olmasından kaynaklı m yazıldı
            db.SaveChanges();
        }
    }
}

public void UpdateProductAttach()
{
    using (var db=new ShopContext())
    {
        var p = new Product() { Id = 3 };
        db.Products.Attach(p); // p entity'si için trancking özelliğini çalıştırdık
        p.Price = 999;
        db.SaveChanges();
    }
}
//Not : bu yöntem tüm alanları güncelleyecektir. Performans açısından dikkate al
public void UpdateProductUpdate()
{
    using (var db=new ShopContext())
    {
        var product = db.Products.Where(p => p.Id == 4).FirstOrDefault();
        if (product != null)
        {
            product.Price = 123;
            db.Products.Update(product);
            db.SaveChanges();
        }
        
    }
}

    #endregion

    #region Remove Methods

    public void RemoveProductsAsTracking(Product product)
    {
        using (var db =new ShopContext())
        {
            Product p = db.Products.FirstOrDefault(x => x.Id == product.Id);
            if (p != null)
            {
                db.Products.Remove(p);
                db.SaveChanges();
            }
        } 
    }
    public void RemoveProductsEntry(Product product)
    {
        using (var db =new ShopContext())
        {
            db.Products.Remove(product);
            db.SaveChanges();
            /*Bu işlem arkada şunları yapmaktadır
             * db.Entry(p).State=EntityState.Deleted
             */
            
        } 
    }
    

    #endregion
}