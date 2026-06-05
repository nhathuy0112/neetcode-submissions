public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> result = new();
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
        foreach(var item in dict)
        {
            result.Add(item.Value);
        }
        return result;
    }
}
