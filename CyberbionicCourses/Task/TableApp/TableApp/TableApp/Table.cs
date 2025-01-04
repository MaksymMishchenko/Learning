namespace TableApp
{
    public class Table
    {
        private readonly IFile _file;
        private readonly int[] _array = {1990, 1991, 1992, 1993, 135, 7290, 11300, 16200};

        public Table(IFile file)
        {
            _file = file;
        }

        //15 минут
        public string PrintOnScreen()
        {
            return string.Join(", ", _array);
        }

        public void Save(string path)
        {
            _file.AppendAllText(path, PrintOnScreen());
        }
    }
}
