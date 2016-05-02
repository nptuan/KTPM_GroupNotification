using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group("KTPM 2013");

            User u = new User("Phuong Tuan", "1312664");
            
            //User subscribe Group
            u.Subscribe(g);

            //New post to Group
            g.NewPost("Video Demo");

            //User unsubscribe Group
            u.Unsubscribe(g);

            //New post to Group
            g.NewPost("File Demo");

            Console.ReadLine();
        }
    }
}
