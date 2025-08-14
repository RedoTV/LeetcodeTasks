public class Solution {
    public int[] SingleNumber(int[] nums) {
        return nums.GroupBy((k) => k).ToDictionary(gr => gr.Key, gr => gr.Count()).Where(gr => gr.Value == 1).Select(gr => gr.Key).ToArray();      
    }
}