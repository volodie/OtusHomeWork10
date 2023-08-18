
namespace OtusHomeWork10
{
    internal class Directories
    {
        public void CreateDirectories(string p, string p1, string p2)
        {
           
            DirectoryInfo dirInfo = new DirectoryInfo(p);
            try
            {
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory(p1);
                dirInfo.CreateSubdirectory(p2);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
    }
}
