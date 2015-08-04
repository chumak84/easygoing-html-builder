using System;
using System.Text;

namespace EasyGoing.HtmlBuilder
{
    public class Head
    {
        public string Title { get; set; } = "Html Builder";

        internal void AppendTo(StringBuilder sb)
        {
            sb.AppendFormat("<head><title>{0}</title></head>", Title);
        }
    }
}