// Sample input
string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

// Instantiate the solution class
GroupAnagramsSolution solution = new GroupAnagramsSolution();

// Call the method
IList<IList<string>> result = solution.GroupAnagram(strs);

// Output the grouped anagrams
Console.WriteLine("Grouped Anagrams:");
foreach (var group in result)
{
    Console.WriteLine($"[{string.Join(", ", group)}]");
}