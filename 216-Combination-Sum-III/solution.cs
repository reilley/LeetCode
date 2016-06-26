public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        return helper(k, 1, n);
        
    }
    
    private IList<IList<int>> helper(int k, int lo, int n){
        IList<IList<int>> aList = new List<IList<int>>();
        if(k<=1 || n<=k) return aList;
        if(k==2){
            for(int i=lo; i<=n/2; i++){
                List<int> list = new List<int>();
                if(i>=n-i || n-i>9) continue;
                list.Add(i);
                list.Add(n-i);
                aList.Add(list);
            }
            
        } else{
            for(int i=lo; i<n/2 && i<10; i++){
                var rest = helper(k-1, i+1, n-i);
                foreach(var rl in rest){
                    var list = new List<int>();
                    list.Add(i);
                    list.AddRange(rl);
                    aList.Add(list);
                }
            }
        }
        return aList;
    }
}