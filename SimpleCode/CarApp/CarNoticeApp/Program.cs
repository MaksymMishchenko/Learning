using System;

namespace CarNoticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLogger carLog = new CarLogger();
            CarNotice carNotice = new CarNotice(carLog);
            carNotice.Drive();
            carNotice.StartEngine();
            carNotice.StartEngine();
            carNotice.Drive();
        }
    }
}
