namespace OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Overloading allows a class to have multiple methods with the same name but different ( type, number, or order of parameters). 
            // Overriding allows a subclass to provide a specific implementation of a method that is already defined in its superclass.

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static occurs at compile time, where the method to be called is determined based on the reference type.
            // Dynamic occurs at runtime, where the method to be called is determined based on the actual object type.
            #endregion


            #region Question 2
            // a)  What is the purpose of the sealed keyword when applied to a class?
            // sealed prevents a class from being inherited . 

            // b)  What is the difference between a sealed class and a sealed method?
            // sealed class cannot be inherited, while sealed method cannot be overridden in derived classes.

            // c)  Can a sealed method be overridden? Why?
            // No, because it is marked as final and cannot be further modified in derived classes.
            #endregion
        }
    }
}
