using System;
using static System.Formats.Asn1.AsnWriter;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class LastStoneWeight
	{
//        **You are given an array of integers stones where stones[i] is the weight of the ith stone.

//        We are playing a game with the stones.On each turn, we choose the heaviest two stones and smash them together.
//        Suppose the heaviest two stones have weights x and y with x <= y.The result of this smash is:

//        If x == y, both stones are destroyed, and
//        If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
//        At the end of the game, there is at most one stone left.

//        Return the weight of the last remaining stone.If there are no stones left, return 0.**

        public static int LastStone(int[] stones)
        {
            // Here, we project each element of the array into an IEnumerable
            // with the form (st, -st), which sets the priority to the inverse
            // of the number, thus allowing us to make a max heap out of the
            // PriorityQueue, which defaults to a min heap.
            var items = stones.Select(st => (st, -st));

            // We take this collection of element-priority pairs and place it
            // into a PriorityQueue, which will assign minimum priority value
            // (that is, higher priority) to the higher element values from the items collection.
            PriorityQueue<int, int> max_heap = new PriorityQueue<int, int>(items);

            // While we have more than one element-priority pair in our PriorityQueue...
            while (max_heap.Count > 1)
            {
                // We define our highest priority element and remove it from the queue.
                int first = max_heap.Dequeue();
                // Then do it again for the second-highest.
                int second = max_heap.Dequeue();
                // We define the difference between the two highest elements.
                int difference = first - second;

                // If both stones are not destroyed, the remaining stone will have a weight
                // equal to the difference between the original two, and is added to the
                // PriorityQueue
                if (difference != 0)
                {
                    max_heap.Enqueue(difference, -difference);
                }
                // Repeat with the new PriorityQueue until only one or zero stones remain.
            }

            // Return the remaining value.
            return max_heap.Peek();
        }
    }
}

