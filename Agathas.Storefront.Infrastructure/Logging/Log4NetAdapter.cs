using Agathas.Storefront.Infrastructure.Configuration;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Logging
{
    public class Log4NetAdapter : ILogger
    {
        private readonly log4net.ILog _log;

        public Log4NetAdapter()
        {
            XmlConfigurator.Configure();

            string loggerName = ApplicationSettingsFactory.GetApplicationSettings().LoggerName;
            _log = LogManager.GetLogger(loggerName);
        }

        public void Log(string message)
        {
            _log.Info(message);
        }
    }
}
