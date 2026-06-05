public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int max = 0;
        HashSet<int> set = new(nums);

        foreach (int num in nums)
        {
            if (!set.Contains(num - 1))
            {
                int length = 1;
                while (set.Contains(num + length))
                {
                    length++;
                }
                max = Math.Max(length, max);
            }
        }
        
        return max;
    }
}
