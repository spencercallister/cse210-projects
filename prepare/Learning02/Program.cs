using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._company = "BYU - Idaho";
        job1._jobTitle = "Data Science Lab Tutor";
        job1._startYear = 2023;
        job1._endYear = 2023;
        
        // job1.DisplayJobDetails();

        Job job2 = new();
        job2._company = "Legrande Health";
        job2._jobTitle = "Data Engineer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // job2.DisplayJobDetails();

        Resume myResume = new();
        myResume._name = "Spencer Callister";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResumeDetails();
    }
}