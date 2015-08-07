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

    } 
}
