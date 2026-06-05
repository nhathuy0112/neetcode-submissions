public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dict = new();
        for(int i = 0; i < s.Length; i++)
        {
            if (!dict.TryAdd(s[i], 1))
            {
                dict[s[i]]++;
            }

            if (!dict.TryAdd(t[i], -1))
            {
                dict[t[i]]--;
            }
        }
        foreach(var item in dict)
        {
            if (item.Value != 0) return false;
        }
        return true;
    }
}
