public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int count = 0;
        int max = 0;
        int limit = nums.Length - 1;
        SortedSet<int> set = new();

        foreach(int num in nums)
        {
            set.Add(num);
        }

        if (set.Count == 1) return 1;

        foreach(int item in set)
        {
            if (set.Contains(item + 1)) count++;
            else 
            {
                max = count > max ? count : max;
                count = 0;
            }
        }

        return max == 0 ? 0 : max + 1;
    }
}
