using System.Text;
using OtusHomeWork10;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"D:\Otus";
        string subpath1 = @"Otus1";
        string subpath2 = @"Otus2";
        //var dirs = new Directories();
        //dirs.CreateDirectories(path, subpath1, subpath2);
        var path1 = Path.Combine(path, subpath1);
        var path2 = Path.Combine(path, subpath2);

        var files = new Files();

        //files.CreateAndWriteFiles(path1, "File");
        //files.CreateAndWriteFiles(path2, "File");
        files.WriteToEndFilesAsync(path1, "File");
        files.WriteToEndFilesAsync(path2, "File");
    }
}