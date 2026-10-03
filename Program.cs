namespace Route_OOP_Ass04;
using Route_OOP_02;
internal class Program
{
    static void Main(string[] args)
    {
        #region theorical ans 1

        // Overloading allows  having multiple methods with same name
        // but different  behaviora based on the parameters passed to the method.
        // Compile-Time Polymorphism
        //------------------------------------------------------//
        // Overriding allows a derived class to provide
        // a specific implementation of a method that is already defined in its base class.
        // Run-Time Polymorphism

        //**************************************************************//

        //Static Binding: the methode is overriden by the keyword "new" in the derived class
        //----------------------------------------------------//
        //Dynamic Binding: the methode is overriden by the keyword "override" in the derived class

        #endregion

        #region theorical ans 2

        // sealed prevents a class from being inherited
        // or a method from being overridden in derived classes
        //**********************************************************//

        //sealed class prevents inheritance the whole class
        //----------------------------------------------//
        //sealed method prevents overriding the method in derived classes
        //**********************************************************//

        //No, a sealed method can't be overridden in a derived class
        //bc The sealed keyword prevents further overriding of the method in derived classes.

        #endregion
        //**********************************************************//

        #region practical ans [a:c]
        Driver driver = new Driver();
        DeliveryCenter center = new DeliveryCenter();

        center.AssignedDriver = driver;
        #endregion

        #region practical ans [d:f]
        StandardShipment STshipment = new StandardShipment();
        ExpressShipment EXshipment = new ExpressShipment();
        InternationalShipment INshipment = new InternationalShipment();
        #endregion

       
    }
}