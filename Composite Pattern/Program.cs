using System.ComponentModel.Design.Serialization;
using Composite_Pattern.OrderSystem;
using Composite_Pattern.ToDoList;

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
            #region ToDoList Example
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
            #endregion

            Console.WriteLine("=========================");

            #region OrderSystem Example
            //look at the image i drew
            Box box1 = new Box();
            Product product1 = new Product(2);
            Product product2 = new Product(3);
            Box box2 = new Box();
            
            box1.Orders.Add(product1);
            box1.Orders.Add(product2);
            box1.Orders.Add(box2);

            Product product3 = new Product(4);
            Box box3 = new Box();

            box2.Orders.Add(product3);
            box2.Orders.Add(box3);

            Product product4 = new Product(5);

            box3.Orders.Add(product4);

            Console.WriteLine(box1.GetPrice());
            #endregion
        }
    }
}
