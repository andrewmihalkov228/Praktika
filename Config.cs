using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace АвторизацияПрактикаКозулин
{
    class Config
    {
        public static bool IsLocked { get; set; }

        public static int failedAttempts = 0;
        public static DispatcherTimer timer;
    }
}
