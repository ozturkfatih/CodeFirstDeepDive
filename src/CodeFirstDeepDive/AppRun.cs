using System;
using System.Diagnostics;
using CodeFirstDeepDive.Service;

namespace CodeFirstDeepDive
{
    public class AppRun
    {
        private readonly ILogService _logService;

        public AppRun(ILogService logService)
        {
            _logService = logService;
        }

        public void Run()
        {
            var watch = Stopwatch.StartNew();
            _logService.LogInfoMessages("Log service is running.");
            watch.Stop();
            Console.ReadKey();
        }
    }
}