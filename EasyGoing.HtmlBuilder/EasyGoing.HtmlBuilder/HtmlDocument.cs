using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder
{
    public class HtmlDocument
    {
        private Html _html;

        public Html Html
        {
            get
            {
                if (_html == null)
                    _html = new Html();
                return _html;
            }
            set
            {
                _html = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(@"<!DOCTYPE html>");

            sb.Append(Html.ToString());

            return sb.ToString();
        }
    }
}
