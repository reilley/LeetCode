public class Twitter {
    private HashMap<Integer, HashSet<Integer>> followTable;
    private HashMap<Integer, LinkedList<Tweet>> tweetsTable;
    private int time = 0;
    /** Initialize your data structure here. */
    public Twitter() {
        followTable = new HashMap<Integer, HashSet<Integer>>();
        tweetsTable = new HashMap<Integer, LinkedList<Tweet>>();
    }
    
    /** Compose a new tweet. */
    public void postTweet(int userId, int tweetId) {
        if(!followTable.containsKey(userId))
            followTable.put(userId, new HashSet<Integer>());
        followTable.get(userId).add(userId);
        if(!tweetsTable.containsKey(userId))
            tweetsTable.put(userId, new LinkedList<Tweet>());
        tweetsTable.get(userId).addFirst(new Tweet(tweetId, time++));
    }
    
    /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
    public List<Integer> getNewsFeed(int userId) {
        List<Integer> list = new ArrayList<Integer>();
        if(!followTable.containsKey(userId)) return list;
        PriorityQueue<Tweet> pq = new PriorityQueue<Tweet>((t1,t2)-> t2.time - t1.time);
        //followTable.get(userId).forEach(id -> tweetsTable.get(id).forEach(pq::add));
        for(int id : followTable.get(userId)){
            if(!tweetsTable.containsKey(id)) continue;
            for(Tweet t : tweetsTable.get(id)) 
                pq.add(t);
        }

        while(pq.size()>0 && list.size()<10){
            list.add(pq.poll().id);
        }
        return list;
    }
    
    /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
    public void follow(int followerId, int followeeId) {
        if(!followTable.containsKey(followerId))
            followTable.put(followerId, new HashSet<Integer>());
        if(!followTable.get(followerId).contains(followeeId))
            followTable.get(followerId).add(followeeId);
    }
    
    /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
    public void unfollow(int followerId, int followeeId) {
        if(followerId==followeeId || 
            !followTable.containsKey(followerId) || 
            !followTable.get(followerId).contains(followeeId)) 
            return;
        followTable.get(followerId).remove(followeeId);
    }
    
    private class Tweet{
        public int id;
        public int time;
        public Tweet(int i, int t){
            id = i;
            time = t;
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.postTweet(userId,tweetId);
 * List<Integer> param_2 = obj.getNewsFeed(userId);
 * obj.follow(followerId,followeeId);
 * obj.unfollow(followerId,followeeId);
 */