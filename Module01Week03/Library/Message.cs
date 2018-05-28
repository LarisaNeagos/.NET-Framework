using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Message
    {
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int Id { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Title { get; set; }

        public Message() { }

        public Message(int id, string title, string content, DateTime date, DateTime modifiedDate)
        {
            Id = id;
            Title = title;
            Content = content;
            Date = date;
            ModifiedDate = modifiedDate;
        }


    }
}
