namespace Models;

public class StudySession
{
    public string Topic { get; }
    public int SpentMinutes { get; private set; }
    private int plannedMinutes;
    public int PlannedMinutes
    {
        get { return plannedMinutes; }
        set
        {
            if (value < 10 || value > 120 || value < SpentMinutes)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Yangi reja 10-120 oralig'ida va sarflangan vaqtdan kam bo'lmasligi kerak.");
            }

            plannedMinutes = value;
        }
    }

    public StudySession(string topic, int plannedMinutes)
    {
        if (string.IsNullOrWhiteSpace(topic))
        {
            throw new ArgumentException("Mavzu bo'sh bo'lmasligi kerak.", nameof(topic));
        }

        Topic = topic;
        PlannedMinutes = plannedMinutes;
    }

    public bool RecordMinutes(int minutes)
    {
        if (minutes > 0 && minutes <= GetRemainingMinutes())
        {
            SpentMinutes += minutes;
            return true;
        }

        return false;
    }

    public int GetRemainingMinutes()
    {
        return PlannedMinutes - SpentMinutes;
    }
}