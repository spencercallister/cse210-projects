using System;

/*

Class: Resume
Attributes:
* _name: string
* _jobs: List<Job>
Behaviors:
* Display(): void

*/

public class Resume
{
    public string _name;
    public List<Job> _jobs = new();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach(Job j in _jobs) 
        
        {
            j.DisplayJobDetails();
        }
    }
}