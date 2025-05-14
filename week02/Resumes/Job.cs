using System;

public class Job
{
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
        Console.WriteLine($"{_companyName} ({_jobTitle}) {_startYear}-{_endYear}");
    }
}