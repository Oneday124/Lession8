// Обход директории. Работа с директориями. С ошибками

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalog = catalog.GetDiretories();
    for(int i = 0; i < catalog.Length; i++)
    {
        System.Console.WriteLine($"{indent} {catalog[i].Name}");
        CatalogInfo(catalog[i].FullName, indent + " ");
    }

    FileInfo[] files = Catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"C:/Users/Саша/Desktop/Обучение";
CatalogInfo(path);

//DirectoryInfo di = new DirectoryInfo(path);
//System.Console.WriteLine(di.CreationTime);
//FileInfo[] fi = di.GetFiles();

//for(int i = 0; i < fi.Length; i++)
//{
//    System.Console.WriteLine(fi[i].Name);
//}
