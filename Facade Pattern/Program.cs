namespace Facade_Pattern
{
    internal class Program
    {
        /*
            what is the purpose of facade pattern?
            let's say you have so many classes and relationships between these
            classes, and the client needs to use these classes and it's painful
            to write the logic that uses these classes.
            now let's say there isn't just one client, but there are multiple 
            clients that use the same classes
            so instead of coding the logic of using these classes multiple times
            which is so bad in maintanance cuz if i changes something in these classes
            i need to go to the places that make use of these classes and change their code
            which is error-prone
            this takes us to: WHAT IS THE FACADE PATTERN?
            facade pattern is a layer or classes between the client and these 
            classes so we can insead of doing the logic of using these classes
            in the client, we gonna do it in facade and use the facade 
            now we can use the facade in multiple places
            and if something changed in these classes, the only thing we gonna change
            is the facade

            you gonna say hmmmmmmmm... isn't this looks like proxy pattern?
            I tell you NO, the difference between most of the structural patterns
            is the intention for using them?
            - facade:  making use of complex relationships and classes easier,
                       it doesn't do anything other than that

            - proxy:   doing some logic like caching, protection etc...

            - adapter: the client uses an interface and want to use someother method
                       in another interface that's not compatible with the current
                       interface the client uses

            - decorator: hooooooooo hoooooooooo, this one am too bad in, cuz it looks
                         exactly looks like proxy, so am not saying anything here
                         untill i compare between it and proxy
            
             ---------------------------------------------------------------
            for the ex. I really don't know something suitable to give an ex of so bear with me
            lets reperesent the complex relationships like that 
            class1 want to use class2
            class3 has class2
            class1 has class3
            client uses class1
         */
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.GetClass2Method();
        }
    }
}
