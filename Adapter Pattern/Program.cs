namespace Adapter_Pattern
{
    internal class Program
    {
        /*
        what's the problem we are facing that it can be solved by adapter pattern?
        lets say u have an interface "Itarget" that uses some method, request() for ex.
        and the client wants instead of using request(), he wants to use some other
        method lets say SpeceficMethod() for ex... in some other interface "IAdaptee"
        so how can we do that? by using adapter pattern
        we gonna create class "Adapter" that implements the interface used by the client 
        and inside that interface we can have an object of the interface that the client
        needs it's method
        the request() method inside the adapter class
        will call that method SpeceficMethod() inside the adaptee class 
        in the example i did, although it's so simple 
        but it's from a real-world example 
        consider you have a method that has some order that you must 
        pass the parameter to it in the same order 
        what if for some reason I wanted the change that order?
        the adapter pattern is one of the ways that can do this

        and remember, adapter pattern achieves open closed principle
        */
        static void Main(string[] args)
        {
            #region ClientUsageBeforeAdapter
            ITarget target = new Target();
            target.request(5, 21.589);
            #endregion

            Console.WriteLine("============================");
            
            #region ClientUsageAfterAdapter
            ITarget target2 = new Adapter(new Adaptee());
            target2.request(5, 21.589);
            #endregion
        }
    }
}
