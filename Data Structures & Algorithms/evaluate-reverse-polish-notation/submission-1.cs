public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        int res = 0;

        Stack<int> nums = new();

        foreach (string item in tokens)
        {
            if (item == "+") nums.Push(nums.Pop() + nums.Pop());
            else if (item == "-")
            {
                int a = nums.Pop();
                int b = nums.Pop();
                nums.Push(b - a);
            }
            else if (item == "*") nums.Push(nums.Pop() * nums.Pop());
            else if (item == "/") 
            {
                int a = nums.Pop();
                int b = nums.Pop();
                nums.Push((int) ((double) b / a));
            }
            else nums.Push(int.Parse(item));
        }    
        return nums.Pop();
    }
}
