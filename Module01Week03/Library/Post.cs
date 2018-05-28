using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Post
    {
        public Person Author { get; set; }
        public Message Message { get; set; }

        public Post() { }

        public Post(Person author, Message message)
        {
            Author = author;
            Message = message;
        }
    }
}
