namespace inherintance.Models;

class Developer : Employee
{
    public string ProgrammingLanguage {get;}

    public Developer(string name, string department, string programmingLanguage) : base(name, department)
    {
        ProgrammingLanguage =programmingLanguage;
    }
}