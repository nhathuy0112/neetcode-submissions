public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] result = new int[nums.Length];
        int before = 1;
        int after = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            result[i] = before;
            before *= nums[i];
        }

        int start = nums.Length - 1;
        for(int i = start; i >= 0; i--)
        {
            result[i] *= after;
            after *= nums[i];
        }
        return result;
    }
}
