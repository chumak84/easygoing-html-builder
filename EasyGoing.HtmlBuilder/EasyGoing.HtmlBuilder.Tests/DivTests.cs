using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder.Tests
{
    [TestFixture]
    class DivTests
    {
        [Test]
        public void CreateDiv_GetString_ReturnsEmptyTag()
        {
            Div d = new Div();
            string html = d.GetString();
            string expected = "<div></div>";
            Assert.AreEqual(expected, html);
        }
        
        [Test]
        public void AddClass_GetString_ReturnsTagWithClassAtribute()
        {
            Div d = new Div();
            d.AddClass("classname");

            string html = d.GetString();
            string expected = "<div class=\"classname\"></div>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddAnoherClass_GetString_ReturnsTagWithClassAtribute()
        {
            Div d = new Div();
            d.AddClass("other");

            string html = d.GetString();
            string expected = "<div class=\"other\"></div>";

            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClasses_GetString_RetuwnsTagWithTwoClasses()
        {
            Div d = new Div();
            d.AddClass("one");
            d.AddClass("two");

            string html = d.GetString();
            string expected = "<div class=\"one two\"></div>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddAttribute_GetString_TagWithAttribute()
        {
            Div d = new Div();
            d.AddAttribute("attname", "val");
            string html = d.GetString();

            string expected = "<div attname=\"val\"></div>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTWoAttributes_GetString_TagWithAttributes()
        {
            Div d = new Div();
            d.AddAttribute("first", "val1");
            d.AddAttribute("second", "val2");
            string html = d.GetString();

            string expected = "<div first=\"val1\" second=\"val2\"></div>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddClassAddAttribute_GetString_TagWithClassesAndAttributes()
        {
            Div d = new Div();
            d.AddClass("one");
            d.AddAttribute("first", "val1");
            string html = d.GetString();

            string expected = "<div class=\"one\" first=\"val1\"></div>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTwoClassAddTwoAttribute_GetString_TagWithClassAndAttribute()
        {
            Div d = new Div();
            d.AddClass("one");
            d.AddClass("two");
            d.AddAttribute("first", "val1");
            d.AddAttribute("second", "val2");
            string html = d.GetString();

            string expected = "<div class=\"one two\" first=\"val1\" second=\"val2\"></div>";
            Assert.AreEqual(expected, html);
        }

        [Test]
        public void AddTag_GetString_RetrnTagWhithChild()
        {
            Div d = new Div();
            d.AddTag("tagname");
            string html = d.GetString();

            string expected = "<div><tagname></tagname></div>";
            Assert.AreEqual(expected, html);
        }
    }
}
