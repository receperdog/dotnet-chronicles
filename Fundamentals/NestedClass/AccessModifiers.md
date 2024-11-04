# C# Access Modifiers Guide

## Access Modifier Hierarchy
From most restrictive to least:
```
private < internal < protected < public
```

## Default Access Modifiers
| Element | Default Modifier |
|---------|-----------------|
| Classes | `internal` |
| Class Members (methods, properties, fields) | `private` |
| Nested Classes | `private` |

## Modifier Descriptions

### `private`
- Only accessible within the containing class
- Most restrictive access level
- Default for class members

```csharp
class Example
{
    private string _secret; // Only accessible inside Example class
}
```

### `internal`
- Accessible within the same assembly (project)
- Default for classes
- Cannot be accessed from other assemblies

```csharp
internal class Helper // Accessible only within same assembly
{
    internal void DoWork() { }
}
```

### `protected`
- Accessible within the class and by derived classes
- Used for inheritance scenarios

```csharp
public class Base
{
    protected void BaseMethod() { } // Accessible in Base and derived classes
}

public class Derived : Base
{
    void Example()
    {
        BaseMethod(); // Can access protected method
    }
}
```

### `public`
- Accessible from anywhere
- Least restrictive access level
- Used for public APIs and interfaces

```csharp
public class PublicAPI
{
    public void DoSomething() { } // Accessible from anywhere
}
```

## Common Use Cases

### When to Use Private (Default)
- Internal implementation details
- Helper methods
- Private fields backing properties
```csharp
public class User
{
    private string _password; // Sensitive data
    private void HashPassword() { } // Implementation detail
}
```

### When to Use Internal
- Classes used only within your assembly
- Implementation classes not meant for public use
```csharp
internal class DatabaseHelper
{
    internal void ConnectToDatabase() { }
}
```

### When to Use Protected
- Base class members that derived classes need
- Template method pattern
```csharp
public abstract class Animal
{
    protected virtual void MakeSound() { }
}
```

### When to Use Public
- Public APIs
- Models and DTOs
- Interface implementations
```csharp
public interface IRepository
{
    public void Save();
}

public class UserModel
{
    public string Name { get; set; }
}
```

## Best Practices

1. **Default to Private**
   - Start with most restrictive access
   - Increase accessibility only when needed

2. **Encapsulation**
   - Keep implementation details private
   - Expose only what's necessary

3. **Interface Segregation**
   - Make public interfaces small and focused
   - Keep internal complexity hidden

4. **Protected Usage**
   - Use protected sparingly
   - Consider if inheritance is really needed

5. **Public API Design**
   - Make public APIs clear and documented
   - Consider backward compatibility

## Common Mistakes to Avoid

1. Making everything public
2. Using protected when inheritance isn't needed
3. Exposing implementation details
4. Not considering assembly boundaries with internal

## Examples

### Good Practice
```csharp
public class UserService
{
    private readonly DatabaseContext _context;
    
    public async Task<User> GetUser(int id)
    {
        return await FindUserById(id);
    }
    
    private async Task<User> FindUserById(int id)
    {
        return await _context.Users.FindAsync(id);
    }
}
```

### Bad Practice
```csharp
public class UserService
{
    public DatabaseContext Context; // Too exposed!
    
    public async Task<User> FindUserById(int id)
    {
        // Implementation details exposed
        return await Context.Users.FindAsync(id);
    }
}
```

## References
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [.NET Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/member-design-guidelines)