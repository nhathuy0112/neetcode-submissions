public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int[] result = new int[k];
        Dictionary<int, int> dict = new();
        foreach(int number in nums)
        {
            if (!dict.TryAdd(number, 1)) 
            {
                dict[number]++;
            }
        }
        int count = 0;
        int i = 0;
        foreach(var item in dict.OrderByDescending(x => x.Value))
        {
            if (count++ == k) break;
            result[i++] = item.Key;
        }
        return result;
    }
}
