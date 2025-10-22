using System;
using System.Text;
using Course.Entities;

namespace Course.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }
    }
}