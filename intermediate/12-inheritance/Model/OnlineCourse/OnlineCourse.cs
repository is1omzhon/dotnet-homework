namespace inherintance.Models;

class OnlineCourse : Course
{
    public LearningPlatform Platform {get;}

    public OnlineCourse(string name, LearningPlatform platform) : base(name)
    {
        Platform = platform;
    }
}