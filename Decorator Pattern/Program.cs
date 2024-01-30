namespace Decorator_Pattern
{
    internal class Program
    {
        /*
         gonna use the example in head-first design patterns book
         that example is a good one for explaining HOW decorator pattern
         works, but it's not a good problem for using decorator pattern
         specifically to it, like u can create a different class called Topping
         with Name and Cost properties
         and pass to the beauverage through constructor a list of toppings
         then iterate on these toppings to calculate the cost of the beauverage
         =======================================================================
         now, one if the most important things
         what do we mean by DECORATOR PATTERN CAN ADD ADDITIONAL FUNCTIONALITY
         AT RUNTIME OR DYNAMICALLY?
         and why we say INHERITANCE IS STATIC?
         DECORATOR PATTERN CAN ADD ADDITIONAL FUNCTIONALITY
         AT RUNTIME OR DYNAMICALLY because in the case of beuverage example
         let's say we have 2 beauverages: espresso and latte
         and let's say we have 2 toppings: mocca and caramel
         now, how the client is using the classes? LOOK at main
         now the mocca class can change it's beheaviour or functionality from
         being just mocca, to be mocca and espresso
         or even mocca and caramel and espresso
         so the same class used the cost method in different functionalities 
         that's what they mean by DYNAMIC or RUNTIME PATTERN
         it doesn't mean u can edit the code during runtime without recompilation
         but it means u can add functionality without changing anything
         */
        static void Main(string[] args)
        {
            Beauverage espresso = new Espresso();//the beauverage
            Beauverage caramel = new CaramelDecorator(espresso);//topping

            Console.WriteLine(caramel.cost());//5+3=8

            Beauverage mocca = new MoccaDecorator(caramel);//8+1=9
            Console.WriteLine(mocca.cost());//5+3=8

        }
    }
}
