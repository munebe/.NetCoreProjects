
using OOPWithRepositoryPattern.BusinessLogicLayer;
using OOPWithRepositoryPattern.DataAccess.Concrete;

//Burada ProductManager içerisine kullanmak istediğimiz Yapıyı parametre olarak gönderebilir ve böylece
// bağımlılığın önüne geçmiş olduk.
var productManager=new ProductManager(new MySqlProductDal());
productManager.Add();