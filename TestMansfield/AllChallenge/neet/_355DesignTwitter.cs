public class Twitter
{

    private static int timestamp = 0;

    private Dictionary<int, User> userMap = new Dictionary<int, User>();


    public Twitter()
    {

    }

    public void PostTweet(int userId, int tweetId)
    {
        if(!userMap.ContainsKey(userId)) userMap.Add(userId,new User(userId));

        var user = userMap[userId];
        user.post(tweetId);
    }

    public IList<int> GetNewsFeed(int userId)
    {
        List<int> res = new List<int>();
        if(!userMap.ContainsKey(userId)) return res;

        var users = userMap[userId].followed;
        PriorityQueue<Tweet, int> pq = 
            new PriorityQueue<Tweet, int>(users.Count(), Comparer<int>.Create((a, b)=> b-a));
        
        foreach (var item in users)
        {
            Tweet twt = userMap[item].head;
            if(twt == null) continue;
            pq.Enqueue(twt,twt.time);            
        }

        while(pq.Count>0)
        {
            if(res.Count == 10) break;
            Tweet twt = pq.Dequeue();
            res.Add(twt.id);
            if(twt.next!=null) pq.Enqueue(twt.next, twt.next.time);
        }
        return res;
        
    }

    public void Follow(int followerId, int followeeId)
    {
        if(!userMap.ContainsKey(followerId)) userMap.Add(followerId,new User(followerId));
        if(!userMap.ContainsKey(followeeId)) userMap.Add(followeeId,new User(followeeId));

        userMap[followerId].follow(followeeId);        
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if(userMap.ContainsKey(followerId)){
            userMap[followerId].unfollow(followeeId);
        }
    }

    private class Tweet
    {
        internal int id;
        internal int time;
        internal Tweet next;

        public Tweet(int id, int time)
        {
            this.id = id;
            this.time = time;
            this.next = null;
        }
    }

    private class User
    {
        private int id;
        public HashSet<int> followed;
        public Tweet head;

        public User(int userId)
        {
            followed = new HashSet<int>();
            this.id = userId;
            this.head = null;
            follow(id);
        }
        public void follow(int userId)
        {
            followed.Add(userId);
        }
        public void unfollow(int userId)
        {
            if (userId != this.id) followed.Remove(userId);
        }
        public void post(int tweetId)
        {
            Tweet twt = new Tweet(tweetId, timestamp);
            timestamp++;
            twt.next = head;
            head = twt;

        }
    }
}