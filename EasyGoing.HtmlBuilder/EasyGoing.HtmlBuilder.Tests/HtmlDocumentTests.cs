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
            string expected = @"<!DOCTYPE html><html><head></head><body></body></html>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void Head_ReturnsHeadObject()
        {
            var doc = new HtmlDocument();
            var head = doc.Head;
            
            Assert.IsInstanceOf<Head>(head);
        }

        [Test]
        public void Body_ReturnsBodyObject()
        {
            var doc = new HtmlDocument();

            Body body = doc.Body;

            Assert.IsInstanceOf<Body>(body);
        }

        [Test]
        public void BodyChanged_GetString_ReturnsCorrectHtml()
        {
            var doc = new HtmlDocument();
            doc.Body.AddClass("one");
            string html = doc.ToString();
            string expected = @"<!DOCTYPE html><html><head></head><body class=""one""></body></html>";

            Assert.AreEqual(expected, html);
        }
    }
}
