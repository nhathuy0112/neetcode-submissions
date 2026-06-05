public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[2];
        Dictionary<int, List<int>> dict = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i], new List<int>() {i}))
            {
                dict[nums[i]].Add(i);
            }
        }
        foreach(var item in dict)
        {
            int key = target - item.Key;

            if (key == item.Key && item.Value.Count() > 1)
            {
                result[0] = item.Value[0];
                result[1] = item.Value[1];
                break;
            } else if (key == item.Key) 
            {
                continue;
            }

            if (dict.ContainsKey(key))
            {
                result[0] = item.Value[0];
                result[1] = dict[key][0];
                break;
            }
        }
        return result;
    }
}
