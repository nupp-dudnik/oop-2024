var text = "This lab is about working with strings and how to manipulate strings. " +
    "First task is to simply count repeating words in a string and print thier occurence. " +
    "Second task is to remove all words from this string.";

var repeating_words = string.Join("", text.Select(c => char.IsPunctuation(c) ? ' ' : c)).Split(' ').Where(s => s.Length > 0)
    .GroupBy(w => w).Where(o => o.Count() > 1).ToDictionary(x => x.Key, y => y.Count());
Console.WriteLine($"Repeating words:\n - {string.Join("\n - ", repeating_words.Select(rw => $"`{rw.Key}` repeats {rw.Value} times"))}");

Console.Write("Enter word to erase: ");
var word = Console.ReadLine();
Console.WriteLine(text.Replace($" {word}", ""));
