public class Solution {
    public bool IsPalindrome(string s) 
    {
        s = Regex.Replace(s, "[^A-Za-z0-9]", string.Empty);

        if (string.IsNullOrEmpty(s)) return true;
        
        int limit = s.Length - 1;
        int middle = limit / 2;

        for (int i = 0; i <= middle; i++)
        {
            char c = Char.ToLower(s[i]);
            char padlinC = Char.ToLower(s[limit - i]);

            if (c != padlinC) return false;
        }

        return true;
    }
}
