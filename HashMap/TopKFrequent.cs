public class TopKFrequentSolution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequency = new();

        // cont frequency
        foreach(int num in nums)
        {
            if(!frequency.ContainsKey(num))
            frequency[num] = 0;

            frequency [num]++;
        }
        
        // bucket array
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in frequency)
        {
            int freq = pair.Value;

            if (buckets[freq] == null)
                buckets[freq] = new List<int>();

                buckets[freq].Add(pair.Key);       
        }

        // travrese from highest frequency 
        List<int> result = new();

        for(int i = buckets.Length - 1; i >= 0; i--)
        {
            if(buckets[i] == null)
            continue;

            result.AddRange(buckets[i]);
        }

        return result.Take(k).ToArray();

    }
    
}


// // run code
// TopKFrequentSolution solution = new TopKFrequentSolution();
// // Test Case 1
// int[] nums1 = { 1, 1, 1, 2, 2, 3 };
// int k1 = 2;
// int[] result1 = solution.TopKFrequent(nums1, k1);
// Console.WriteLine($"Test Case 1 Output: [{string.Join(", ", result1)}]");
// // Test Case 2
// int[] nums2 = { 1 };
// int k2 = 1;
// int[] result2 = solution.TopKFrequent(nums2, k2);
// Console.WriteLine($"Test Case 2 Output: [{string.Join(", ", result2)}]");
    