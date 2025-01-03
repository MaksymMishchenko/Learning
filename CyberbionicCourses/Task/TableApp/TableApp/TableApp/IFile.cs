namespace TableApp
{
    public interface IFile
    {
        void AppendAllText(string path, string printOnScreen);
    }
}