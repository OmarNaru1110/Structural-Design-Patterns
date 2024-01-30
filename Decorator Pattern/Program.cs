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
