using System;

namespace Business.CSS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Loglandı");
        }
    }

}
