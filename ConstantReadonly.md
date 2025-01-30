## What is the difference between **Constants** and **Readonly** variables?

| Feature               | **const**               | **readonly**      |
|-----------------------|--------------------------------------|------------------------------------------|
| **Declaration**       | `const` keyword                     | `readonly` keyword                      |
| **Initialization**    | Must be initialized at declaration  | Can be initialized at declaration or in the constructor |
| **Modifiable**        | Not modifiable after declaration    | Not modifiable after initialization     |
| **Value Set Time**    | Compile-time                        | Compile-time or Runtime (usually in the constructor)    |
| **Can be declared inside the method** | Yes         | No     |
| **Can be used with static modifiers** | No (because `const` is implicitly `static` and belongs to the type, not an instance) | Yes, `readonly` fields can be static if explicitly declared as `static readonly` |
| **Usage**             | Fixed values like mathematical constants (`PI`, `MaxValue`)  | Values that may change based on runtime conditions but should remain immutable after initialization (e.g., configuration values, API keys) |
| **Examples**          | `public const double PI = 3.14159;`<br>`public const int MaxUsers = 100;` | `public readonly string ConnectionString;`<br>`ConnectionString = GetConnectionString();` |

### Real-life Usage Examples

#### **Using `const` for fixed values**
```csharp
public class MathConstants
{
    public const double PI = 3.14159; // A mathematical constant that never changes
    public const int MaxUsers = 100;  // A system-wide fixed limit
}

#### **Using `readonly` for runtime-initialized values**
```csharp
public class AppConfig
{
    public readonly string ConnectionString;

    public AppConfig()
    {
        ConnectionString = GetDatabaseConnection(); // Can be set at runtime
    }

    private string GetDatabaseConnection()
    {
        return "Server=myServer;Database=myDB;";
    }
}

### This means:

- const is used for fixed values that will never change.
- readonly is used for values that need to be initialized at runtime but must remain unchanged afterward.
