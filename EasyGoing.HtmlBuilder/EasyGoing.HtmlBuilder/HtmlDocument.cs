using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder
{
    public class HtmlDocument
    {
        Head _head = new Head();

        public Body Body { get; } = new Body();
        public Head Head { get; } = new Head();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(@"<!DOCTYPE html><html>");

            Head.AppendTo(sb);
            sb.Append(Body.GetString() + "</html>");

            return sb.ToString();
        }
    }
}
