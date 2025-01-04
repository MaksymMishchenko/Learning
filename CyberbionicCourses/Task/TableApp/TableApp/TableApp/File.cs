namespace TableApp
{
    class File : IFile
    {
        public void AppendAllText(string path, string contents)
        {
            System.IO.File.AppendAllText(path, contents);
        }
    }
}