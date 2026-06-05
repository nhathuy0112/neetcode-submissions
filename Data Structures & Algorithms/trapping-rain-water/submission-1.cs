public class Solution {
    public int Trap(int[] height) 
    {
        int res = 0;
        if (height == null || height.Length == 0) return 0;

        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                res += leftMax - height[left];
            } 
            else 
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                res += rightMax - height[right];
            }
        }
        return res;
    }
}
