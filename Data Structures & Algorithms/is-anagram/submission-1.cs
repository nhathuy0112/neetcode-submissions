public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dictS = new();
        foreach(char c in s)
        {
            if(!dictS.TryAdd(c, 1))
            {
                dictS[c]++;
            }
        }
        foreach(char c in t)
        {
            if(dictS.ContainsKey(c))
            {
                dictS[c]--;
            }
        }
        foreach(var item in dictS)
        {
            if (item.Value != 0) return false;
        }
        return true;
    }
}
