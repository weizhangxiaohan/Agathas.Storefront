using Agathas.Storefront.Infrastructure.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Logging.Tests
{
    [TestClass]
    public class Log4NetAdapterTest
    {
        [TestMethod]
        public void Log() 
        {
            ApplicationSettingsFactory.InitializeApplicationSettingsFactory(new MockApplicationSetting());

            Log4NetAdapter logger = new Log4NetAdapter();
            logger.Log("test===hello");
        }
    }

    public class MockApplicationSetting : IApplicationSettings
    {

        public string LoggerName
        {
            get 
            { 
                return "xxx";
            }
            
        }

        public string NumberOfResultsPerPage
        {
            get
            {
                return "6";
            }
        }
    }
}
