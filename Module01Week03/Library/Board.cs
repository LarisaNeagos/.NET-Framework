using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Board
    {
        public List<Post> Posts { get; set; }

        public Board()
        {
        }

        public Board(List<Post> posts)
        {
            Posts = posts;
        }
    }
}
