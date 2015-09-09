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
        public void CreateHead_ToString_ReturnsEmptyTag()
        {
            Head head = new Head();

            string actual = head.ToString();
            string expected = "<head></head>";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateHead_ToStringAppendTo_ReturnsSameResult()
        {
            Head head = new Head();

            string actual = head.ToString();

            StringBuilder sb = new StringBuilder();
            head.AppendTo(sb);

            Assert.AreEqual(actual, sb.ToString());
        }

        [Test]
        public void HeadWithTitle_ToString_ReturnHeadWithTitle()
        {
            Head head = new Head();
            head.Title = "some title";

            string actual = head.ToString();
            string expected = "<head><title>some title</title></head>";

            Assert.AreEqual(expected, actual);
        }
    }
}
