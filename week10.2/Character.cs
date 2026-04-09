namespace week10._2;

public class Character
{
    public string Name { get; private set; }
    public string Role { get; private set; }
    public int Level { get; private set; }
    public int Health { get; private set; }
    public int Gold { get; private set; }
    public string State { get; private set; }

    public Character(string name, string role, int level, int health, int gold, string state)
    {
        Name = name;
        Role = role;
        Level = level;
        Health = health;
        Gold = gold;
        State = state;
    }
}