class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        existedNums = set()
        for num in nums:
            if existedNums.__contains__(num):
                return True
            else:
                existedNums.add(num)
        return False