public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int[] result = new int[k];
        Dictionary<int, int> dict = new();
        List<int>[] rank = new List<int>[nums.Length + 1];

        for(int i = 0; i < rank.Length; i++)
        {
            rank[i] = new();
        }

        foreach(int number in nums)
        {
            if (!dict.TryAdd(number, 1)) 
            {
                dict[number]++;
            }
        }
        
        foreach(var item in dict)
        {
            rank[item.Value].Add(item.Key);
        }

        int start = rank.Length - 1;
        int count = 0;
        for(int i = start; i > 0 && count < k; i--)
        {
            foreach(int item in rank[i])
            {
                if (count == k) break;
                result[count++] = item;
            }
        }
        return result;
    }
}
