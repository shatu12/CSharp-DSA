public class ContainDuplicateSolution
{
    public bool ContainDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}

// // Sample input array
// int[] nums = new int[] { 1, 2, 3, 1 };

// // Instantiate the solution class
// ContainDuplicateSolution solution = new ContainDuplicateSolution();

// // Call the method
// bool result = solution.ContainDuplicate(nums);

// // Output the result
// Console.WriteLine($"Contains Duplicate: {result}");