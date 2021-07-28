using System.Collections.Generic;

namespace lunch_buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy.LunchBuddy("Jack", "Parsons");
            lunchBuddy.Eat();
            lunchBuddy.Eat("burrito");
            lunchBuddy.Eat(new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Macho", "Man"),
                new LunchBuddy.LunchBuddy("Ultimate", "Warrior")
            });
            lunchBuddy.Eat("Misir Wat", new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Jake the", "Snake"),
                new LunchBuddy.LunchBuddy("Randy", "Savage")
            });


        }
    }
}
