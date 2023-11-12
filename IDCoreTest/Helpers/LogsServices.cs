 using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using ILogger = Serilog.ILogger;

namespace IDCoreTest.Helpers
{
    public static class LogsServices
    {
        private static readonly ILogger _logger;

        static LogsServices()
        {

            _logger = Log.Logger;
        }

        public static void LogCatchError(Exception e, string message = "Catch Error")
        {
            _logger.Information("----------- Start Error -------------------");
            _logger.Error(e, message);
            _logger.Information("------------- End Error -----------------");
        }
        public static void LogError(  string message )
        {
            _logger.Information("----------- Start Error -------------------");
            _logger.Error(message);
            _logger.Information("------------- End Error -----------------");
        }
    }
}