using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public class IMailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mail gönderildi...: C001: Oyun Aktivasyonunuz Başlatılmıştır...");
        }
    }
}
