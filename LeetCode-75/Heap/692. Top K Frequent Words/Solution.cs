class Solution {
    public List<String> topKFrequent(String[] words, int k) {
        // Create a hashmap to count the frequency of each word
        Map<String, Integer> count = new HashMap<String, Integer>();
        for (String word : words) {
            count.put(word, count.getOrDefault(word, 0) + 1);
        }
        
        // Create a priority queue to store the top k frequent words
        PriorityQueue<String> heap = new PriorityQueue<String>(new Comparator<String>() {
            @Override
            public int compare(String a, String b) {
            int freq1 = count.get(a);
            int freq2 = count.get(b);
            if (freq1 != freq2) {
            return freq2 - freq1;
        } else {
            return a.compareTo(b);
        }
        }
        });
        
        // Add each word to the priority queue
        for (String word : count.keySet()) {
            heap.offer(word);
        }
        
        // Build the result list
        List<String> result = new ArrayList<String>();
        for (int i = 0; i < k; i++) {
            result.add(heap.poll());
        }
        
        return result;
    }
}