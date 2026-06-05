class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        existedNums = set()
        for num in nums:
            if num in existedNums:
                return True
            else:
                existedNums.add(num)
        return False