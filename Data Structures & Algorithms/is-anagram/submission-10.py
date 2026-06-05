class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        existed_characters = {}

        for character in s:
            if character not in existed_characters:
                existed_characters[character] = 1
            else:
                existed_characters[character] += 1

        for character in t:
            if character not in existed_characters:
                return False
            else:
                existed_characters[character] -= 1
                if existed_characters[character] < 0:
                    return False
        return True