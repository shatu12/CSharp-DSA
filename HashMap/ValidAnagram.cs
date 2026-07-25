public class ValidAnagramSolution
{
    public bool IsValidSolution(string word1, string word2)
    {
        if(word1.Length != word2.Length)
        {
            return false;
        }

        int[] count = new int[26];

        foreach(char word in word1)
        {
            count [word - 'a']++;
        }

        foreach(char word in word2)
        {
            count[word-'a']--;
        }

        foreach(int value in count)
        {
            if(value != 0)
             return false;
        }

        return true;
    }
}

// run

// var solver = new ValidAnagramSolution();
// bool result = solver.IsValidSolution("silent", "isten");
// Console.WriteLine($"Result: {result}");



// // Instantiate the solver
// var solver = new ValidAnagramSolution();

// // Test Case 1: Is an anagram
// string word1 = "silent";
// string word2 = "listen";
// bool result1 = solver.IsValidSolution(word1, word2);
// Console.WriteLine($"Is '{word1}' an anagram of '{word2}'? {result1}");

// // Test Case 2: Not an anagram (different lengths)
// string word3 = "silent";
// string word4 = "isten";
// bool result2 = solver.IsValidSolution(word3, word4);
// Console.WriteLine($"Is '{word3}' an anagram of '{word4}'? {result2}");