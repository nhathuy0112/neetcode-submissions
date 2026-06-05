public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> dict = new();
        foreach(string item in strs)
        {
            char[] characters = item.ToArray();
            Array.Sort(characters);
            string sortedCharacters = new string(characters);

            if (!dict.TryAdd(sortedCharacters, new List<string>() { item }))
            {
                dict[sortedCharacters].Add(item);
            }
        }
        return new List<List<string>>(dict.Values);
    }
}
