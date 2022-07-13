#region Directory Operation
//  @ escape character for file path.
// oluşturulacak dosyayı path stringi içerisine yaz. Dosya eğer varsa hata vermeyecektir.
//Directory.CreateDirectory(@"D:\Projects\OperationsTutorials\test");

//Dosya Mevcut mu?: True, False
//Console.WriteLine(Directory.Exists( @"D:\Projects\OperationsTutorials\test"));

// param1: taşınacak dosya, param2: taşınacak dosya
//Directory.Move(@"D:\Projects\OperationsTutorials\test", @"D:\Projects\test1");

//Directory.Delete(@"D:\Projects\test1");
#endregion

#region File operations
// READ
string[] lines = System.IO.File.ReadAllLines(@"D:\Projects\OperationsTutorials\TextData.txt");
foreach (var line in lines)
{
    Console.WriteLine(line);
}
// WRITE
string[] lines2 =
{
    "First line", "Second line", "Third line" 
};
await File.WriteAllLinesAsync("WriteLines.txt", lines2);
#endregion



