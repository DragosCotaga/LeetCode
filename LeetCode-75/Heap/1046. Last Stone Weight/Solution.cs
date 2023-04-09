import java.util.PriorityQueue;

class Solution {
    public int lastStoneWeight(int[] stones) {
        // Create a max heap to store the weights of stones
        PriorityQueue<Integer> heap = new PriorityQueue<>((x, y) -> y - x);
        for (int stone : stones) {
            heap.offer(stone);
        }
        
        // Smash stones until there is at most one left in the heap
        while (heap.size() > 1) {
            int y = heap.poll();
            int x = heap.poll();
            if (x != y) {
                heap.offer(y - x);
            }
        }
        
        // Return the weight of the last remaining stone, or 0 if there are none
        return heap.isEmpty() ? 0 : heap.peek();
    }
}

