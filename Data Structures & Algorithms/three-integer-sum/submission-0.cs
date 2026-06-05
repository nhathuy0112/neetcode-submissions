public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> res = new();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i-1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];

                if (sum > 0) right--;
                else if (sum < 0) left++;
                else 
                {
                    res.Add(new List<int>() {nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                    while (nums[left] == nums[left - 1] && left < right) left++;
                }
            }
        }

        return res;
    }
}
