public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> set = new();
        foreach(int number in nums)
        {
            if(!set.Add(number))
            {
                return true;
            }
        }
        return false;
    }
}
