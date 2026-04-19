using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Book
{
    public string Title;
    public string Author;
    public int Pages;
    public List<string> Chapters;
    public int BookMark;
    public int Price;
    public bool IsAvailable;

    public Book(string title, string author, int pages, int price)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Price = price;
        Chapters = new List<string>();
        IsAvailable = true;
    }

    public bool IsBookAvailable()
    {
        return IsAvailable;
    }

    public string GetChapter(int index)
    {
        if (index < Chapters.Count)
            return Chapters[index];
        else
            return "Invalid";
    }

    public int GetBookMark()
    {
        return BookMark;
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book("OOP", "Ali", 200, 500);
        b.Chapters.Add("Intro");

        Console.WriteLine(b.GetChapter(0));
    }
}
