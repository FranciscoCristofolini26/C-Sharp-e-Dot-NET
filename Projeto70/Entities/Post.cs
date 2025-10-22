using System;
using System.Net.Http.Headers;
using System.Transactions;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}