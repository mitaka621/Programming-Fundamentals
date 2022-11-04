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
            int n = int.Parse(Console.ReadLine());
            Article[] a=new Article[n];
            for (int i = 0; i < n; i++)
            {
                string[] input2 = Console.ReadLine().Split(", ").ToArray();
                a[i]=new Article(input2[0], input2[1], input2[2]);
            }
            string input=Console.ReadLine();
            //while ((input=Console.ReadLine())!= "title"&&input!= "content"&&input!= "author")
            //{

            //}

            foreach (Article item in a)
            {
                Console.WriteLine(item.ToString());
            }
            
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
