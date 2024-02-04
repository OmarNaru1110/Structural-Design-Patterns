using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.ToDoList
{
    internal class NodeToDo : IToDo
    {
        public string Text { get; set; }
        public List<IToDo> Projects { get; set; }
        public NodeToDo(string text)
        {
            Projects = new List<IToDo>();
            Text = text;
        }
        public string Get()
        {
            string result = "";
            result += "<ul>\n";
            result += "<li> " + Text + " </li>\n";
            foreach (var item in Projects)
            {
                result += "<ul>\n";
                result += item.Get();
                result += "</ul>\n";
            }
            result += "</ul>\n";
            return result;
        }
    }
}
