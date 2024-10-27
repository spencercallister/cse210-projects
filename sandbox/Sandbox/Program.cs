using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        Query query = new();
        query.TestamentSelect();
        query.BookSelect();
        query.ChapterSelect();
        query.VerseSelect();
        query.GetVerseText();
    }
}