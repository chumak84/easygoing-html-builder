using System.Collections.Generic;

namespace EasyGoing.HtmlBuilder
{
    public class Body
    {
        private List<string> _name =  new List<string>();

        private string name;
        public string GetString()
        {
            if (_name.Count > 0)
            {
                for (int i = 0; i < _name.Count; i++)
                {
                    if (i > 0)
                    {
                        name += " " + _name[i];
                    }
                    else
                    {
                        name += _name[i];
                    }
                }
                return "<body class=\"" + name + "\"></body>";
            }
            return "<body></body>";

        }
        public void AddClass(string classname)
        {
            _name.Add(classname);

        }
    }
}