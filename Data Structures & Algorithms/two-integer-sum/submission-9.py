class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        position = {}

        for index, num in enumerate(nums):
            second_num = target - num

            if second_num in position:
                return [position[second_num], index]
            else:
                position[num] = index

        return []