using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Article a = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input2 = Console.ReadLine().Split(": ").ToArray();
                switch (input2[0])
                {
                    case "Edit":
                        a.Edit(input2[1]);
                        break;
                    case "ChangeAuthor":
                        a.ChangeAuthor(input2[1]);
                        break;
                    case "Rename":
                        a.Rename(input2[1]);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(a.ToString());
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

    }
}
