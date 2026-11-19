namespace inherintance.Models;

class Student : Person
{
    public string Course{get;}

    public Student(string course, string name) : base(name)
    {
        Course = course;
    }
    
}