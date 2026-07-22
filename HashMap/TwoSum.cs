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