using System;

public class Program
{
    public static void Main(string[] args)
    {
    /*  Action is a generic delegate type, but it represents a method that takes parameters of types T1, T2, ..., Tn and does not return a value (void).
        It can represent a method with up to 16 input parameters. */
        
        Action<int, int> printSumAction = (a, b) => Console.WriteLine(a+b);
        printSumAction(5, 3);
        
        Console.WriteLine("................");
        
    /*  Func<T1, T2, ..., TResult>:  
        Func is a generic delegate type that represents a method that takes
        parameters of types T1, T2, ..., Tn and returns a result of type
        TResult.
        Like Action, it can represent a method with up to 16 input parameters
        The last type parameter (TResult) represents the return type.*/
        
        Func<int, int, double> addFunction = (a, b) => a + b;
        var result = addFunction(3, 5);
        Console.WriteLine(result.GetType() == typeof(double));
        
        Console.WriteLine("................");
        
    /*  Predicate is a generic delegate type that represents a method that takes one input parameter and returns a Boolean value.
        It has a single method signature bool Predicate<T>(T obj).
        Predicate<T> is equivalent to Func<T, bool>. */
        
        Predicate<int> isEven = (x) => x%2 == 0;
        Console.WriteLine(isEven(3));

        Console.ReadKey();
    }
    
}