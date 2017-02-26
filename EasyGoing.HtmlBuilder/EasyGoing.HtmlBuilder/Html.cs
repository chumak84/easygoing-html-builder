using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder
{
    public class Html
    {
        private Head _head;
        private Body _body;

        public Head Head
        {
            get
            {
                if (_head == null)
                    _head = new Head();
                return _head;
            }
            set
            {
                _head = value;
            }
        }

        public Body Body
        {
            get
            {
                if (_body == null)
                    _body = new Body();
                return _body;
            }
            set
            {
                _body = value;
            }
        }

        public override string ToString()
        {
            return @"<html lang=""en""><head></head><body></body></html>";
        }
    }
}
