from queue import PriorityQueue
from typing import List


class Solution:
    def maxProduct(self, nums: List[int]) -> int:

        max_queue = PriorityQueue()

        for num in nums:
            max_queue.put(num*-1)

        first_item = max_queue.get()*-1
        second_item = max_queue.get()*-1

        result = ((first_item - 1) * (second_item - 1))

        return result
