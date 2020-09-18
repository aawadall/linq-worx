# linq-worx

## Voting time
What should be the next hackathon about?

[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Continue%20with%20LINQ)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Continue%20with%20LINQ/vote)
[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/SignalR)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/SignalR/vote)
[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Unity%20DI)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Unity%20DI/vote)
[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Angular)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Angular/vote)
[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/BDDs)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/BDDs/vote)
[![](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Other%2C%20please%20open%20an%20issue%20for%20it)](https://api.gh-polls.com/poll/01EJGRQAAW96N0ECT0WY89VSFD/Other%2C%20please%20open%20an%20issue%20for%20it/vote)


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
