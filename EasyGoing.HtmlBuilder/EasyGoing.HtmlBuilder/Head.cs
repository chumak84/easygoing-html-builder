using System;
using System.Text;

namespace EasyGoing.HtmlBuilder
{
    public class Head
    {
        public string Title { get; set; } = "";

        public void AppendTo(StringBuilder sb)
        {
            sb.Append("<head>");
            if(!string.IsNullOrWhiteSpace(Title))
            {
                sb.AppendFormat("<title>{0}</title>", Title);
            }
            sb.Append("</head>");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            this.AppendTo(sb);

            string result = sb.ToString();
            return result;
        }
    }
}