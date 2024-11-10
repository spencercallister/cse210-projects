Inheritance is structuring your code in parent and child classes, which allows the child classes to inherit the attributes and methods of the parent class. This makes it so the attributes and methods that multiple classes have in common with each other can be shared by the parent class, rather than defining the same things multiple times, making your code more clean and efficient.

An application of inheritence would be an online store that sells shirts, pants, and socks. Imagine each type of clothing is its own class, but they still have attributes in common, like gender, size, color, etc. They also have attributes unique to each of them, for example the shirts might have a collar type attribute, while the pants have one for the in-seam. Instead of redefining the variables that are in common for each class, we can create a parent class called "clothing", which will store the attributes for gender, size, color, etc. In the individual classes, those attributes that only belong to them will go there.

In my code for the Mindfulness program, I have a parent class called "Activity" which has the following function called "StartMessage":

```
public void StartMessage()
{
    Console.Clear();
    Console.Write($"""
    Welcome to the {_name} Activity.

    {_description}

    For how long in seconds would you like the session to last: 
    """);

    string duration = Console.ReadLine();
    _duration = Int32.Parse(duration);
    Console.Clear();
    Console.WriteLine("Get Ready...");
    Pause();
    Console.WriteLine("");
}
```

Since this is in the parent class, I do not have to define it in each of the child classes, but I can just call it as it is inherited. Here is where it is called in the Breathing class:

```
public Breathing(string name, string description) : base(name, description)
{
    StartMessage(); # right here
    Execute(BreatheMessage);
    EndMessage();
}
```
Now when an object with the Breathing class is initialized, it will run the StartMessage function. The same happens for the Reflection and Listing classes.
