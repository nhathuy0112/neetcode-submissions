public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack = new();

        Dictionary<char, char> dict = new()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (!dict.ContainsKey(c)) stack.Push(c);
            else if (stack.Count == 0 || stack.Pop() != dict[c]) return false;
        }

        return stack.Count == 0;
    }
}
