using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupNotification
{
    public class Post
    {
        private string _content;
        public Post(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }
    }
}