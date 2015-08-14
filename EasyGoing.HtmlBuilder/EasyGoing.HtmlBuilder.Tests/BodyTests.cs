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

        [Test]
        public void AddClass_GetString_ReturnsTagWithClassAtribute()
        {
            Body b = new Body();
            b.AddClass("classname");

            string html = b.GetString();
            string expected = "<body class=\"classname\"></body>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddAnoherClass_GetString_ReturnsTagWithClassAtribute()
        {
            Body b = new Body();
            b.AddClass("other");

            string html = b.GetString();
            string expected = "<body class=\"other\"></body>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClasses_GetString_RetuwnsTagWithTwoClasses()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddClass("two");

            string html = b.GetString();
            string expected = "<body class=\"one two\"></body>";
            Assert.AreEqual(expected, html);

        }

        [Test]
        public void AddAttribute_GetString_TagWithAttribute()
        {
            Body b = new Body();
            b.AddAttribute("attname", "val");
            string html = b.GetString();

            string expected = "<body attname=\"val\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTWoAttributes_GetString_TagWithAttributes()
        {
            Body b = new Body();
            b.AddAttribute("first", "val1");
            b.AddAttribute("second", "val2");
            string html = b.GetString();

            string expected = "<body first=\"val1\" second=\"val2\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddClassAddAttribute_GetString_TagWithClassesAndAttributes()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddAttribute("first", "val1");
            string html = b.GetString();

            string expected = "<body class=\"one\" first=\"val1\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClassAddTwoAttribute_GetString_TagWithClassAndAttribute()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddClass("two");
            b.AddAttribute("first", "val1");
            b.AddAttribute("second", "val2");
            string html = b.GetString();

            string expected = "<body class=\"one two\" first=\"val1\" second=\"val2\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTag_GetString_RetrnTagWhithChild()
        {
            Body b = new Body();
            b.AddTag("tagname");
            string html = b.GetString();

            string expected = "<body><tagname></tagname></body>";
            Assert.AreEqual(expected, html);
        }
    }
}
