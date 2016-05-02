using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupNotification
{
    public class Group
    {
        private string _name;
        protected List<User> _subscribers = new List<User>();
        protected List<Post> _post = new List<Post>();
        
        public Group(string name)
        {
            this.Name = name;
        }

        public bool Subscribe(User user)
        {
            Console.WriteLine(user.Name + " Subscribe " + this.Name);
            _subscribers.Add(user);
            return true;
        }
        public bool Unsubscribe(User user)
        {
            Console.WriteLine(user.Name + " Unsubscribe " + this.Name);
            _subscribers.Remove(user);
            return true;
        }
        public void NotifyAll(Post item)
        {
            foreach (User user in _subscribers)
                user.Notify(this, item);
        }
        internal void NewPost(string content)
        {
            Console.WriteLine(this.Name + " has a new post");
            _post.Add(new Post(content));
            NotifyAll(_post[_post.Count - 1]);
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}