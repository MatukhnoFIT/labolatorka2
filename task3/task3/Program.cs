using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Book
    {
        public string book;
        void Show()
        {
            Console.Write($"\nКнига: {this.book}");
        }
    }

    class Title
    {
        public string title;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nBook title: {this.title}");
        }
    }

    class Author
    {
        public string author;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\nАuthor: {this.author}");
        }
    }

    class Content
    {
        public string content;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\nContent: {this.content}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Type name of book: ");
            title.title = Console.ReadLine();
            Console.WriteLine("Type autor of book:");
            author.author = Console.ReadLine();
            Console.WriteLine("Type content of book: ");
            content.content = Console.ReadLine();

            title.Show();
            author.Show();
            content.Show();


            Console.Read();

        }
    }
}
