public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length==0 || nums2.Length==0) return new int[0];
        int m = nums1.Length;
        int n = nums2.Length;
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i=0, j=0;
        var list = new List<int>();
        while(i<m && j<n){
            if(nums1[i]>nums2[j]) j++;
            else if(nums1[i]<nums2[j]) i++;
            else{
                list.Add(nums1[i]);
                i++;
                j++;
            }
        }
        return list.ToArray();
    }
}