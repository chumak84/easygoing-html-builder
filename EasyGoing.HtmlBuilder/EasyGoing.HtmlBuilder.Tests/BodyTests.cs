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
        public void CreateBody_ToString_ReturnsEmptyTag()
        {
            Body body = new Body();

            string actual = body.ToString();
            string expected = "<body></body>";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddClass_ToString_ReturnsTagWithClassAtribute()
        {
            Body b = new Body();
            b.AddClass("classname");

            string html = b.ToString();
            string expected = "<body class=\"classname\"></body>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddAnoherClass_ToString_ReturnsTagWithClassAtribute()
        {
            Body b = new Body();
            b.AddClass("other");

            string html = b.ToString();
            string expected = "<body class=\"other\"></body>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClasses_ToString_RetuwnsTagWithTwoClasses()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddClass("two");

            string html = b.ToString();
            string expected = "<body class=\"one two\"></body>";
            Assert.AreEqual(expected, html);

        }

        [Test]
        public void AddAttribute_ToString_TagWithAttribute()
        {
            Body b = new Body();
            b.AddAttribute("attname", "val");
            string html = b.ToString();

            string expected = "<body attname=\"val\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTWoAttributes_ToString_TagWithAttributes()
        {
            Body b = new Body();
            b.AddAttribute("first", "val1");
            b.AddAttribute("second", "val2");
            string html = b.ToString();

            string expected = "<body first=\"val1\" second=\"val2\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddClassAddAttribute_ToString_TagWithClassesAndAttributes()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddAttribute("first", "val1");
            string html = b.ToString();

            string expected = "<body class=\"one\" first=\"val1\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClassAddTwoAttribute_ToString_TagWithClassAndAttribute()
        {
            Body b = new Body();
            b.AddClass("one");
            b.AddClass("two");
            b.AddAttribute("first", "val1");
            b.AddAttribute("second", "val2");
            string html = b.ToString();

            string expected = "<body class=\"one two\" first=\"val1\" second=\"val2\"></body>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTag_ToString_RetrnTagWhithChild()
        {
            Body b = new Body();
            b.AddTag("tagname");
            string html = b.ToString();

            string expected = "<body><tagname></tagname></body>";
            Assert.AreEqual(expected, html);
        }
    }
}
