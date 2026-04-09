namespace week10._2;

public class Event
{
    public int Number { get; private set; }
    public string Description { get; private set; }
    public string Type { get; private set; }
    public string CharChange { get; private set; }

    public Event(int number, string description, string type, string charChange)
    {
        Number = number;
        Description = description;
        Type = type;
        CharChange = charChange;
    }
}