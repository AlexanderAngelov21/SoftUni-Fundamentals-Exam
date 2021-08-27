using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var firstString = Console.ReadLine().Split(" | ");
        var listDictionary = new SortedDictionary<string, List<string>>();
        foreach (var item in firstString)
        {
            var wordDefinition = item.Split(": ");
            if (!listDictionary.ContainsKey(wordDefinition[0]))
            {
                listDictionary.Add(wordDefinition[0], new List<string>() { $" -{wordDefinition[1]}" });
            }
            else
            {
                listDictionary[wordDefinition[0]].Add($" -{wordDefinition[1]}");
            }
        }
        var secondCheckWordString = Console.ReadLine().Split(" | ");
        var command = Console.ReadLine();
        if (command == "Test")
        {
            foreach (var word in secondCheckWordString)
            {
                if (listDictionary.ContainsKey(word))
                {
                    foreach (var item in listDictionary.Where(x => x.Key == word))
                    {
                        Console.WriteLine($"{item.Key}:");
                        Console.WriteLine(string.Join("\n", item.Value.OrderByDescending(x => x.Length)));
                    }
                }
            }
        }
        if (command == "Hand Over")
        {
            Console.WriteLine(string.Join(" ", listDictionary.Select(x => x.Key)));
        }
    }
}