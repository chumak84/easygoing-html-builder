using System;
using System.Collections.Generic;

namespace EasyGoing.HtmlBuilder
{
    public class Body
    {
        private List<string> _classNames = new List<string>();

        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        public string GetString()
        {
            if (_classNames.Count > 0)
            {
                string name = string.Join(" ", _classNames);
                return "<body class=\"" + name + "\"></body>";
            }
            if (_attributes.Count > 0)
            {
                string result = "<body";
                foreach (KeyValuePair<string, string> p in _attributes)
                {
                    result += " " + p.Key;
                    result += "=\"";
                    result += p.Value + "\"";
                }
                result += "></body>";
                return result;
            }
            return "<body></body>";
        }

        public void AddClass(string classname)
        {
            _classNames.Add(classname);
        }

        public void AddAttribute(string attname, string val)
        {
            _attributes.Add(attname, val);
        }
    }
}