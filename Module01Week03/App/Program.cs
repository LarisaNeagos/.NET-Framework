using System;
using Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person
            {
                LastName = "Popescu",
                FirstName = "Ana",
                BirthDate = DateTime.Now,
                Email = "a@gmail.com",
                Password = "pas"
                
            };

            Message message = new Message
            {
                Content = "Hello",
                Date = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Title = "How  are you ?"
            };

            Post post = new Post() { Message = message, Author = person };
            Board board = new Board();
            board.Posts.Add(post);
        }
    }
}
