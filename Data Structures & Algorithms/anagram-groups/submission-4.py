class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        if len(strs) == 1:
            return [strs]

        store = {}

        for word in strs:
            sorted_word = "".join(sorted(word))

            if sorted_word in store:
                store[sorted_word].append(word)
            else:
                store[sorted_word] = [word]

        res = []

        for value in store.values():
            res.append(value)

        return res