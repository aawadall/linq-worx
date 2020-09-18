# linq-worx

## Vote 
[![](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option1)](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option1/vote)
[![](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option%202)](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option%202/vote)
[![](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option%203)](https://api.gh-polls.com/poll/01BY7ECS60GG8F9AR1VMR8745S/Option%203/vote)

please go directly to folder 17_Sept 

## Objectives 
* Lambda Expressions 
* Extension Methods 
* Pipeline
* Anonymous Types 
* Query Expression Syntax 
* Generics 
* yield and var 

### Lambda Expressions 
**Lambda vs Delegates**

_Delegate_
```csharp
customers.Where(delegate(Customer c){
    return c.Email ~= null;})
```

_Lambda_
```csharp
customers.Where(c => c.Email != null)
```
### Extension Methods 
Extend existing types 
* static class 
* static method 
```csharp
static class TypeXExtensions 
{
    public static TypeY ExtMethod(this TypeX x)
    {
        return SomeMethod(x).SomeOtherMethod();
    }
}
```

**For Linq**
```csharp 
public static SomeType SomeMethod(this IEnumerable<T> list)
{
    \\ some code 
}
```
### Anonymous Types 
```csharp
var x = something();
```

### Query Expression Syntax 
### Generics 
### yield and var 
