public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dictForS = new();
        Dictionary<char, int> dictForT = new();
        for(int i = 0; i < s.Length; i++)
        {
            if (!dictForS.TryAdd(s[i], 1))
            {
                dictForS[s[i]]++;
            }

            if(!dictForT.TryAdd(t[i], 1))
            {
                dictForT[t[i]]++;
            }
        }
        foreach(var item in dictForS)
        {
            if (!dictForT.TryGetValue(item.Key, out int value)) return false;
            if (item.Value != value) return false;
            
        }
        return true;
    }
}
