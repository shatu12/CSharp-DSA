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