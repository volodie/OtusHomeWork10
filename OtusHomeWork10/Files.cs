using System.Text;

namespace OtusHomeWork10
{
    internal class Files
    {
        public void CreateAndWriteFiles(string path, string nameFiles)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    var sb = new StringBuilder(nameFiles);
                    sb.Append(i.ToString());
                    sb.Append(".txt");
                    var exists = File.Exists(Path.Combine(path, sb.ToString()));
                    if (!exists)
                    {
                        using (FileStream fs = File.Create(Path.Combine(path, sb.ToString())))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
                            fs.Write(info, 0, info.Length);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public async Task WriteToEndFilesAsync(string path, string nameFiles)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    var sb = new StringBuilder(nameFiles);
                    sb.Append(i.ToString());
                    sb.Append(".txt");
                    var exists = File.Exists(Path.Combine(path, sb.ToString()));
                    if (exists)
                    {
                        await File.AppendAllTextAsync(Path.Combine(path, sb.ToString()), "\n"+DateTime.Now.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
