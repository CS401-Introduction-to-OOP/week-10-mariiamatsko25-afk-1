using System.Collections;
namespace week10._2;

public class EventLog : IEnumerable<Event>
{
    private List<Event> events = new List<Event>();

    public void Add(Event ev)
    {
        events.Add(ev);
    }

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var ev in events)
        {
            yield return ev;
        }
    }

    public IEnumerable<Event> GetChronology()
    {
        var evByNumber = events.OrderBy(ev => ev.Number);
        
        foreach (var ev in evByNumber)
        {
            yield return ev;
        }
    }

    public IEnumerable<Event> GetType(string type)
    {
        foreach (var ev in events)
        {
            if (ev.Type == type)
            {
                yield return ev;
            }
        }
        
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
}