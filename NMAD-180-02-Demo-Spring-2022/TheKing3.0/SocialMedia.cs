using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKing3._0
{
    class SocialMedia
    {
        Dictionary<string, List<Friend>> profile = new Dictionary<string, List<Friend>>();
        List<Friend> friends;
        public bool AddFriend(string name, Friend friend)
        {
            if(profile.TryGetValue(name, out friends))
            {
                
                profile[name].Add(friend);
                return true;
            }
            else
            {
                friends = new List<Friend>();
                friends.Add(friend);
                
                profile.Add(name, friends);
                return true;
            }
            
        }
        
        public bool RemoveFriend(string name, string friendToRemove)
        {
            List<Friend> friends = profile[name];
            foreach(Friend friend in friends)
            {
                if (friend.Name == friendToRemove)
                {
                    friends.Remove(friend);
                    return true;
                }
                    
            }

            return false;

        }

        public void showProfiles()
        {
            foreach(KeyValuePair<string, List<Friend>> item in profile)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void ShowAllFriend(string name)
        {
            //foreach(KeyValuePair<string, List<Friend>> item in profile)
            //{
            //    Console.WriteLine(item.Key);
            //}
            Console.WriteLine($"Showing {name}'s friends");
            List<Friend> friends = profile[name];
            Console.WriteLine(friends.Count);
            foreach(Friend friend in friends)
            {
                Console.WriteLine(friend.ToString());
            }


        }

        public void showAllFriendsInTheNetwork()
        {
            foreach(KeyValuePair<string, List<Friend>> item in profile)
            {
                Console.WriteLine($"{item.Key}'s friends");
                foreach(Friend friend in item.Value)
                {
                    Console.WriteLine($"\t{friend.ToString()}");
                }

            }
        }
    }
}
