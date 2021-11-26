using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Core;

namespace TextEditor.ViewModel.Services
{
    public class MyLogger
    {
         Logger _logger;
        public Logger Logger => _logger;

        public MyLogger(string FileName)
        {
            this._logger = new LoggerConfiguration()
                .WriteTo.File(FileName)
                .CreateLogger();
        }
    }
}
