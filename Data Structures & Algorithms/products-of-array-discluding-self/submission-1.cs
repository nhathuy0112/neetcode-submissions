public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] result = new int[nums.Length];

        for(int i = 0; i < result.Length; i++)
        {
            int value = 1;

            int before = i - 1;
            int after = i + 1;

            while(before >= 0)
            {
                value *= nums[before];
                before--;
            }

            while(after <= nums.Length - 1)
            {
                value *= nums[after];
                after++;
            }

            result[i] = value;
        }

        return result;
    }
}
