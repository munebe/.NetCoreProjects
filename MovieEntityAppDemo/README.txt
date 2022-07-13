
#region Baslangic Islemleri
/* 1-Paket kurulumları
 *      microsoft.entityframeworkcore.design
 *      microsoft.entityframeworkcore.sqlserver
 *      microsoft.extensions.configuration
 *      system.data.sqlclient
 *
 * 2-Entity sınıflarının oluşturulması
 * 3-Context sınıfının oluşturulması
 * 4-Konsol komutları
 *      dotnet ef migrations add InitialCreate
 *      dotnet ef database update
 */
#endregion

#region Logging
 Çalıştırılan sorguları loglamak için 
  "Microsoft.Extensions.Logging.Console" paketini ekle
   1- public static readonly ILoggerFactory MyLoggerFactory      = LoggerFactory.Create(builder => { builder.AddConsole(); });
 *    2- optionsBuilder
 *         .UseLoggerFactory(MyLoggerFactory) //loglama yapısı için   




#region Database Shema Update
/*
 *  Tablolarda yapılan bir güncellemeyi şemaya aktarmak için veya yeni bir tablo açtığımızda 
 *   1- "dotnet ef migrations add migration_adi"
 *   2-  "dotnet ef database update" 
 */
#endregion

