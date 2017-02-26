using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder.Tests
{
    [TestFixture]
    public class HtmlTests
    {
        [Test]
        public void ToString_ReturnsDefaultHtmlWithHeadAndBody()
        {
            Html html = new Html();
            var expected = @"<html lang=""en""><head></head><body></body></html>";

            Assert.AreEqual(expected, html.ToString());
        }

        [Test]
        public void Head_GetHead_DefaultNotNull()
        {
            Html html = new Html();

            Assert.NotNull(html.Head);
        }

        [Test]
        public void Head_HeadReplaced_ObjectTheSame()
        {
            Html html = new Html();
            var expected = new Head();
            html.Head = expected;

            Assert.AreEqual(expected, html.Head);
        }

        [Test]
        public void Body_GetBody_DefaultNotNull()
        {
            Html html = new Html();

            Assert.NotNull(html.Body);
        }

        [Test]
        public void Body_BodyReplaced_ObjectTheSame()
        {
            Html html = new Html();
            var expected = new Body();
            html.Body = expected;

            Assert.AreEqual(expected, html.Body);
        }
    }
}
