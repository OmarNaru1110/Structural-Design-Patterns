namespace Flyweight_Pattern
{
    internal class Program
    {
        /*
        flyweight pattern is kinda look like the cache proxy pattern
        well, the job is similar but the implementation is kinda different
        flyweight pattern is used most of the time with factory pattern
        why do we need flyweight pattern?
        well, think of a scenario that u need multiple complex objects from database
        which will take some time, and there're multiple classes that needs the same
        objects that u want, yep The SAME, they don't need to change any of them
        then, it's a waste of time and resources to retreive them from the database
        we just need to cache them using ???? yep flyweight pattern or caching proxy
        --------------------------------------
        REAL WORLD SCENARIO
        let's say you have a coffe shop 
        and u have two types of discount
        1) discount based on the date: like on everyday u have somekind of discount
        2) discount based on the item that is bought, like latte has 15% discount
        both of discounts implement IDiscount Interface
        and there are a factory class that u give it either "day" or "item"
        and based of that, it will return to u either ItemDiscount obj or DateDiscount obj
        and ofc returning these objects require some time cuz they are returned from DB
        or they require complex computation or anything 
        */
        static void Main(string[] args)
        {
            #region without flyweight
            DiscountFactory discountFactory = new DiscountFactory();
            var item = discountFactory.GetDiscount("item");
            Console.WriteLine(item.GetDiscountValue(DateTime.Now));
            #endregion

            #region with flyweight
            FlyweightDiscount flyweight= new FlyweightDiscount();
            flyweight.GetDiscount("item");
            flyweight.GetDiscount("item");
            #endregion
        }
    }
}
