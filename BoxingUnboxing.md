## What is **Boxing** and **Unboxing**?

### **Boxing**:
- **Boxing** is the process of converting a **value type** (e.g., `int`, `bool`) into a **reference type** (i.e., `object` or an interface).
- Boxing occurs automatically (**implicit cast**), meaning you do not need to explicitly specify the type conversion.
  
### **Unboxing**:
- **Unboxing** is the process of converting a **reference type** (object) back to a **value type**.
- Unboxing requires an **explicit cast**, meaning you must manually specify the type to convert back to the original value type. If the cast is incorrect, it will throw an `InvalidCastException`.

### Example of Both:
```csharp
int num = 5; // value type
object obj = num; // implicit boxing (value type -> reference type)
int unboxedNum = (int)obj; // explicit unboxing (reference type -> value type)
```

### Key Points:
- **Boxing** is **automatic** (implicit) because the compiler knows how to wrap a value type inside an object.
- **Unboxing** is **explicit** because you must ensure the type is correct before extracting it from an object.
