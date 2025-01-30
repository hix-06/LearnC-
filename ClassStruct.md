## What is the difference between **struct** and **class**? 
| Feature               | **Class**                                               | **Struct**                                          |
|-----------------------|---------------------------------------------------------|-----------------------------------------------------|
| **Type**              | Reference type                                          | Value type                                          |
| **Memory Allocation** | Allocated on the heap                                   | Allocated on the stack                              |
| **Inheritance**       | Supports inheritance                                    | Does not support inheritance                        |
| **Constructors**      | Can have custom parameterized and parameterless constructors | Can have parameterized constructors but cannot define a custom parameterless constructor (the compiler provides a default one that initializes all fields) |
| **Use Cases**         | Ideal for complex data and objects with many fields     | Best for small, lightweight data structures that don't require inheritance |

### Examples

#### Class
```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    // Custom parameterless constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
    }
    
    // Custom parameterized constructor
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }
}
```

#### Struct
```csharp
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    
    // Parameterized constructor (allowed)
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    // Parameterless constructor (not allowed - compiler provides one)
    // public Point() { X = 0; Y = 0; } // This would cause a compilation error
}
