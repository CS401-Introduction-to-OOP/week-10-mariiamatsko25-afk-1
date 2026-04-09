namespace week10._2;

class Program
{
    static void Main(string[] args)
    {
        Party party = new Party();
        Character c1 = new Character("Lisa", "archer", 1, 100, 50, "active");
        Character c2 = new Character("Masha", "defeater", 2, 100, 30, "active");
        Character c3 = new Character("Egor", "archer", 5, 67, 78, "not active");
        party.Add(c1);
        party.Add(c2);
        party.Add(c3);

        EventLog eventLog = new EventLog();

        Event ev1 = new Event(1, "war with witches", "war", "+45 gold");
        Event ev2 = new Event(2, "rescue citizens", "operation of rescue", "+50 HP");
        Event ev3 = new Event(3, "battle with dragons", "battle", "-30 HP");
        
        eventLog.Add(ev1);
        eventLog.Add(ev2);
        eventLog.Add(ev3);

        while (true)
        {
            Console.WriteLine("Choose command you want:");
            Console.WriteLine("1: events with type war");
            Console.WriteLine("2: characters with HP lower than 80");
            Console.WriteLine("3: active characters");
            Console.WriteLine("4: chronological events");
            Console.WriteLine("5: number of archers in the game");
            Console.WriteLine("6: ordering by gold");
            Console.WriteLine("7: characters' names");
            Console.WriteLine("8: count of all characters");
            Console.WriteLine("9: max health through of all characters");
            Console.WriteLine("10: average amount of gold");
            Console.WriteLine("11: grouping characters by role");
            Console.WriteLine("0: exit from the game");
            
            Console.WriteLine("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Events with type war:");
                foreach (var ev in eventLog.GetType("war"))
                {
                    Console.WriteLine($"- {ev.Description}");
                }
                Console.WriteLine();
            }

            if (choice == "2")
            {
                Console.WriteLine("Characters with HP less than 80:");
                foreach (var c in party.GetHP(80))
                {
                    Console.WriteLine($"{c.Name} - {c.Health} HP");
                }
                Console.WriteLine();
            }

            if (choice == "3")
            {
                Console.WriteLine("Active characters:");
                foreach (var c in party.GetActive())
                {
                    Console.WriteLine($"- {c.Name}");
                }
                Console.WriteLine();
            }

            if (choice == "4")
            {
                Console.WriteLine("Chronological events:");
                foreach (var ev in eventLog.GetChronology())
                {
                    Console.WriteLine($"{ev.Number}. {ev.Description}");
                }
                Console.WriteLine();
            }

            if (choice == "5")
            {
                var archers = party.Where(c => c.Role == "archer");
                Console.WriteLine($"Number of archers in the game is {archers.Count()}");
                Console.WriteLine();
            }

            if (choice == "6")
            {
                Console.WriteLine("Ordering by gold:");
                var orderBygold = party.OrderBy(c => c.Gold);
                foreach (var c in orderBygold)
                {
                    Console.WriteLine($"{c.Name} - {c.Gold}");
                }
                Console.WriteLine();
            }

            if (choice == "7")
            {
                Console.WriteLine("Character names:");
                var selectNames = party.Select(c => c.Name);
                foreach (var select in selectNames)
                {
                    Console.WriteLine($"- {select}");
                }
                Console.WriteLine();
            }

            if (choice == "8")
            {
                int countOfCharacters = party.Count();
                Console.WriteLine($"Count of all characters is {countOfCharacters}");
                Console.WriteLine();
            }

            if (choice == "9")
            {
                int maxHealth = party.Max(c => c.Health);
                Console.WriteLine($"Max amount of health is {maxHealth}");
                Console.WriteLine();
            }

            if (choice == "10")
            {
                double averageGold = party.Average(c => c.Gold);
                Console.WriteLine($"Average amount of gold of all characters is {averageGold:F2}");
                Console.WriteLine();
            }

            if (choice == "11")
            {
                var groupByRole = party.GroupBy(c => c.Role);
                foreach (var group in groupByRole)
                {
                    Console.WriteLine($"Count of characters with role {group.Key} is {group.Count()}");
                }
                Console.WriteLine();
            }

            if (choice == "0")
            {
                break;
            }
        }
    }
}