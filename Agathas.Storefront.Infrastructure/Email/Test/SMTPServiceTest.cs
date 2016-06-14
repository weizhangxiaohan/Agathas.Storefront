using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Email.Test
{
    [TestClass]
    public class SMTPServiceTest
    {
        [TestMethod]
        public void SendEmail() 
        {
            SMTPService s = new SMTPService();
            s.SendMail("191689072@qq.com","191689072@qq.com","1","2");
        }
    }
}
