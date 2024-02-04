using System.ComponentModel.Design.Serialization;

namespace Composite_Pattern
{
    internal class Program
    {
        /*
            - GrandFather
                - father
                    - child 1
                - mother
                    - child 2
        */
        static void Main(string[] args)
        {
            NodeToDo grandfather = new NodeToDo("GrandFather");
            NodeToDo father = new NodeToDo("father");
            IToDo child1 = new LeafToDo("child 1");
            NodeToDo mother = new NodeToDo("mother");
            IToDo child2 = new LeafToDo("child 2");
            grandfather.Projects.Add(father);
            grandfather.Projects.Add(mother);
            father.Projects.Add(child1);
            mother.Projects.Add(child2);
            Console.WriteLine(grandfather.Get());
        }
    }
}
