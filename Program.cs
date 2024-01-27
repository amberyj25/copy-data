using System;
using System.IO;

class Program
{
    static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        string fileAPath = Path.Combine(desktopPath, "data.txt");
        string fileBPath = Path.Combine(desktopPath, "dataCopy.txt");

        if (File.Exists(fileAPath))
        {
            try
            {
                File.Copy(fileAPath, fileBPath, true);
                Console.WriteLine($"已將 {fileAPath} 的內容複製到 {fileBPath}");
            }
            catch (Exception)
            {
                Console.WriteLine($"沒有複製");
                throw;
            }
        }
        else
        {
            Console.WriteLine($"找不到檔案 {fileAPath}。");
        }
    }
}