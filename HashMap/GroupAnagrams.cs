public class GroupAnagramsSolution
{
    public IList<IList<string>> GroupAnagram(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();

        foreach (var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(word);
        
        }

        return groups.Values.Cast<IList<string>>().ToList();
    }
    
}


//run//
// var solver = new GroupAnagramsSolution();
// var result = solver.GroupAnagram(new string[] {"eat","tea","tan","ate","nat","bat"});
// Console.WriteLine($"Result: {string.Join(" | ", result.Select(g => "[" + string.Join(",", g) + "]"))}");


// // Sample input
// string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

// // Instantiate the solution class
// GroupAnagramsSolution solution = new GroupAnagramsSolution();

// // Call the method
// IList<IList<string>> result = solution.GroupAnagram(strs);

// // Output the grouped anagrams
// Console.WriteLine("Grouped Anagrams:");
// foreach (var group in result)
// {
//     Console.WriteLine($"[{string.Join(", ", group)}]");
// }