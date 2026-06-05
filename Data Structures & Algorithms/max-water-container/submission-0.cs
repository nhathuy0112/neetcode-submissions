public class Solution {
    public int MaxArea(int[] heights) 
    {
        int max = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right)
        {
            int l = right - left;

            int smaller = Math.Min(heights[left], heights[right]);
            int amount =  l * smaller; 
            
            max = Math.Max(max, amount);

            if (smaller == heights[left]) left++;
            else right--;
        }

        return max;
    }
}
