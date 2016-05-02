using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupNotification
{
    public class User
    {
        private string _id;
        private string _name;
        private List<Group> _group = new List<Group>();

        public User(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public void Subscribe(Group group)
        {
            group.Subscribe(this);
            _group.Add(group);
        }
        public void Unsubscribe(Group group)
        {
            group.Unsubscribe(this);
            _group.Remove(group);
        }
        public void Notify(Group group, Post post)
        {
            Console.WriteLine(this.Name + " Notification: " + group.Name.ToString().ToUpper() + " has a new post: \"" + post.Content + "\"");
        }      
        public string ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
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