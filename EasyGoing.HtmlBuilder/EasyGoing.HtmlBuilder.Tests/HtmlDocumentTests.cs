using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder.Test
{
    [TestFixture]
    public class HtmlDocumentTests
    {
        [Test]
        public void TestInitial()
        {
            var doc = new HtmlDocument();

            string html = doc.ToString();
            string expected = @"<!DOCTYPE html><html lang=""en""><head></head><body></body></html>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void Html_ReturnsHtmlObject()
        {
            var doc = new HtmlDocument();
            var html = doc.Html;
            
            Assert.IsInstanceOf<Html>(html);
        }
    }
}
