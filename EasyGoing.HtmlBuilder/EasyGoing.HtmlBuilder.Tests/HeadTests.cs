using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder.Tests
{
    [TestFixture]
    class HeadTests
    {
        [Test]
        public void CreateHead_GetString_ReturnsEmptyTag()
        {
            Head head = new Head();

            string actual = head.GetString();
            string expected = "<head></head>";

            Assert.AreEqual(expected, actual);
        }
    }
}
