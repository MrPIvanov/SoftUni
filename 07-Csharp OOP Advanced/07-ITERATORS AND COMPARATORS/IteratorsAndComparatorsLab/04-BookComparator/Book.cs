﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public int Year { get; set; }
    public IReadOnlyList<string> Authors { get; set; }

    public Book(string title, int year,params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors.ToList();
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }

    public int CompareTo(Book other)
    {
        var result = this.Year.CompareTo(other.Year);

        if (result==0)
        {
            result = this.Title.CompareTo(other.Title);
        }
        return result;
    }
}