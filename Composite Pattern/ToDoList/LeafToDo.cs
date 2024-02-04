using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.ToDoList
{
    internal class LeafToDo : IToDo
    {
        public LeafToDo(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public string Get()
        {
            return "<li> " + Text + " </li>\n";
        }
    }
}
