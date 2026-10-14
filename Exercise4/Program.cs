// 🎵 4. Spellista Städare
// Be användaren skriva in låttitlar och skapa en lista.
// Ta bort dubbletter med .Distinct()
// Filtrera låtar som börjar med en viss bokstav med .FindAll()
// Gör alla titlar till versaler med .ConvertAll()
//  💡 Extra: Använd .Reverse() för att vända listan.
List<string> songTitles = new();

while (true)
{
    Console.WriteLine("Skriv in en låttitel som du vill lägga till i din lista:");
    string userInput = Console.ReadLine() ?? "";

    if (userInput.Length < 3)
    {
        break;
    }

    songTitles.Add(userInput);
}

songTitles = songTitles.Distinct().ToList();

Console.Write("Filtrera låtar som börjar med bokstaven: ");
char filterLetter = Console.ReadKey().KeyChar;
Console.WriteLine();

List<string> filteredSongs = songTitles
    .FindAll(title => title.StartsWith(filterLetter.ToString(), StringComparison.OrdinalIgnoreCase))
    .ToList();

filteredSongs = filteredSongs.ConvertAll(title => title.ToUpper());

filteredSongs.Reverse();

Console.WriteLine("Resultat:");
foreach (string title in filteredSongs)
{
    Console.WriteLine(title);
}
