Encapsulation is making variables and sometimes functions only accessible within certain contexts and restricted in the way they may be used, making them useable only in the way you intend them to be. The benefit is that it makes your program secure so it is harder to break it and expose data and functions that should not be exposed. 

Imagine a hospital with an online system that allows both employees and patients to access and manage patient data securely. When patients log in, they interact with a PatientPortal class that provides access to their personal information, medical history, billing details, and messages from their doctors, while restricting access to sensitive data meant for staff. Conversely, employees log into an EmployeePortal class, which grants them access to multiple patients' records and administrative functions based on their roles. This system uses encapsulation to bundle relevant data and methods within each class, ensuring that each user type only sees the information pertinent to them, thus maintaining privacy and data integrity.

In the Scripture Memorizor program I wrote, I used the following example of encapsulation:

```
class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public void DisplayRef()
    {
        if(_verseEnd != null) Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}"); else Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        
    }
}
```

This class restricts the way in which the variables `_book`, `_chapter`, `_verseStart`, and `_verseEnd` may be set or retrieved. With the constructors, the user is required to provide a book, a chapter, and a verse start, but it allows the user to choose to provide a verse end or not. Since these variables are private, the user must wait until the `DisplayRef()` method is called to actually view the variables, which means they can only view them in the format provided.