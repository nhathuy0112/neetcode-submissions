public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> dict = new();
        foreach(string item in strs)
        {
            int[] alphabet = new int[26];
            foreach(char character in item)
            {
                alphabet[character - 'a']++;
            }
            string key = string.Join(',', alphabet);

            if (!dict.TryAdd(key, new List<string>() {item}))
            {
                dict[key].Add(item);
            }
        }
        return new List<List<string>>(dict.Values);
    }
}
