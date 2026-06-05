public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int firstNumber = target - nums[i];

            if (dict.ContainsKey(firstNumber))
            {
                return new int[] {dict[firstNumber], i};
            }

            dict.Add(nums[i], i);
        }
        return default;
    }
}
