public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int>pair = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++)
        {
            int rest = target - nums[i];

            if (pair.ContainsKey(rest))
            {
                return new int[]{pair[rest],i};
            }

            if (!pair.ContainsKey(nums[i]))
            {
                pair.Add(nums[i],i);
            }
        }

        return new int[0];
    }
}

// // Sample input data
// int[] nums = new int[] { 2, 7, 11, 15 };
// int target = 9;

// // Instantiate the solution class
// TwoSumSolution solution = new TwoSumSolution();

// // Call the method
// int[] result = solution.TwoSum(nums, target);

// // Print the output
// if (result.Length == 2)
// {
//     Console.WriteLine($"Indices found: [{result[0]}, {result[1]}]");
// }
// else
// {
//     Console.WriteLine("No two sum solution found.");
// }

