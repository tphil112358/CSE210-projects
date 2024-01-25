using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Tyler Phillips";

        Job job = new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Robinhood";
        job._startYear = 2002;
        job._endYear = 2021;
        myResume.jobs.Add(job);

        job = new Job();
        job._jobTitle = "Full-Time Missionary";
        job._company = "The Church of Jesus Christ of Latter-Day Saints";
        job._startYear = 2021;
        job._endYear = 2023;
        myResume.jobs.Add(job);

        myResume.DisplayResume();
    }
}