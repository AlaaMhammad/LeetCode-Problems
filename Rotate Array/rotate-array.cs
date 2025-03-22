public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n; // تعديل k في حالة كانت أكبر من طول المصفوفة
        Reverse(nums, 0, n - 1);  // عكس المصفوفة بأكملها
        Reverse(nums, 0, k - 1);  // عكس الجزء الأول (k عناصر)
        Reverse(nums, k, n - 1);  // عكس الجزء الثاني (باقي العناصر)
    }
    
    // دالة لعكس جزء من المصفوفة من الفهرس left إلى right
    private void Reverse(int[] nums, int left, int right) {
        while (left < right) {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}