Polymorphism is the ability for objects to take on multiple forms. In C#, polymorphism is implemented through interfaces and abstract classes. Interfaces allow multiple classes to implement the same interface, while abstract classes can be used as a base class for multiple derived classes. This means the base class essentially acts as a template for the other classes, either allowing them to override or use a default method or forcing them to override the method.

The benefits of polymorphism include:

1. Code reusability: By defining a common interface or base class, you can create a set of related classes that can be used interchangeably.
2. Flexibility: Using interfaces and abstract classes allows you to create flexible and extensible code.
3. Maintainability: Polymorphism can make your code more maintainable by allowing you to add new functionality to existing classes without modifying them directly.

An application of Polymorphism is a base class called "TextMessage" which has child classes called "OptIn", "Promotion", and "OptOut". The base class has the attributes "_body", "_fromNumber", and "_toNumber". The base class also has the methods "Send" (a virtual method), "GetBody", "GetNumbers", and "Display". The child class "Promotion" overrides the "Send" method incorporating code to handle repeated text messages. This is so the "Promotion" child class can send repeated promotional text messages as reminders to its customers using its unique integer "_frequency" attribute. The other child classes "OptIn" and "OptOut" do not override the "Send" method, but instead call the base class method. Overall, the program's use of polymorphism gives flexibility to a businesses SMS marketing needs.

In my code, I incorporated polymorphism by creating an abstract base class called "Goal" which has a method called `GetAllDetails()` as seen below:
```
public abstract string GetAllDetails();
```

This is then overridden in the child classes:

Simple Class:
```
    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()},{GetCompleted()}";
    }
```

Eternal Class:
```
    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()}";
    }
```

Checklist Class:
```
    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()},{_bonusPoints},{_completionLimit},{_timesCompleted}";
    }
```

This allows me to use a single method to return a string with the details of a goal, regardless of its type making it easier to insert the data into a .txt file.
