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