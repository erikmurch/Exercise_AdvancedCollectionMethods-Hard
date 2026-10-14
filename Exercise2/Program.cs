// 📋 2. To-Do Manager
// Bygg en enkel konsolapp där användaren kan lägga till, visa och ta bort uppgifter.
// Använd .ForEach() för att visa alla
// Använd .RemoveAll() för att ta bort klara uppgifter
//  💡 Extra: Säkerställ att inga dubbletter finns med .Distinct().

List<string> tasks = new();
bool keepRunning = true;

while (keepRunning)
{
    Console.WriteLine("1. Lägg till uppgift");
    Console.WriteLine("2. Visa uppgifter");
    Console.WriteLine("3. Ta bort uppgift");
    Console.WriteLine("4. Avsluta");
    Console.Write("Välj: ");
    string menuChoice = Console.ReadLine() ?? "";

    switch (menuChoice)
    {
        case "1":
            Console.Write("Skriv det du vill lägga till: ");
            string newTask = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newTask) && !tasks.Contains(newTask))
            {
                tasks.Add(newTask);
            }
            break;

        case "2":
            if (tasks.Count == 0)
            {
                Console.WriteLine("Inga uppgifter att visa.");
            }
            else
            {
                tasks.ForEach(task => Console.WriteLine(task));
            }
            break;

        case "3":
            Console.Write("Skriv uppgiften som ska tas bort: ");
            string taskToRemove = Console.ReadLine() ?? "";
            tasks.RemoveAll(task => task.Equals(taskToRemove, StringComparison.OrdinalIgnoreCase));
            break;

        case "4":
            keepRunning = false;
            break;

        default:
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}