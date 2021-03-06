﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGoing.HtmlBuilder
{
    public class Tag
    {
        protected List<Tag> _tags = new List<Tag>();
        protected List<string> _classNames = new List<string>();
        protected Dictionary<string, string> _attributes = new Dictionary<string, string>();

        public string Name { get; private set; }

        public Tag(string name)
        {
            Name = name;
        }
        
        public void AddTag(string tagname)
        {
            Tag t = new Tag(tagname);
            _tags.Add(t);
        }

        public void AddClass(string classname)
        {
            _classNames.Add(classname);
        }

        public void AddAttribute(string attname, string val)
        {
            _attributes.Add(attname, val);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<{0}", Name);
            if (_classNames.Count > 0)
            {
                string name = string.Join(" ", _classNames);
                sb.AppendFormat (" class=\"{0}\"", name);
            }
            if (_attributes.Count > 0)
            {
                foreach (KeyValuePair<string, string> p in _attributes)
                {
                    sb.AppendFormat(" {0}", p.Key);
                    sb.AppendFormat("=\"");
                    sb.AppendFormat("{0}\"", p.Value);
                }
            }
            if (_tags.Count > 0)
            {
                foreach (Tag t in _tags)
                {
                    string name = t.Name;
                    sb.AppendFormat ("><{0}></{0}", name);
                }
            }
            sb.AppendFormat("></{0}>", Name);
            return sb.ToString();
        }

    }
}
