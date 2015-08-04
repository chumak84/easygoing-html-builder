using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder.Tests
{
    [TestFixture]
    class BodyTests
    {
        [Test]
        public void CreateBody_GetString_ReturnsEmptyTag()
        {
            Body body = new Body();

            string actual = body.GetString();
            string expected = "<body></body>";

            Assert.AreEqual(expected, actual);
        }
    }
}
