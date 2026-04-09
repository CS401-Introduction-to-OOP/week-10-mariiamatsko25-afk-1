using System.Collections;
namespace week10._2;

public class Party : IEnumerable<Character>
{
    private List<Character> characters = new List<Character>();

    public void Add(Character character)
    {
        characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var c in characters)
        {
            yield return c;
        } 
    }

    public IEnumerable<Character> GetActive()
    {
        foreach (var c in characters)
        {
            if (c.State == "active")
            {
                yield return c;
            }
        }
    }

    public IEnumerable<Character> GetHP(int hp)
    {
        foreach (var c in characters)
        {
            if (c.Health < hp)
            {
                yield return c;
            }
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}