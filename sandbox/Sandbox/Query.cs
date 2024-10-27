using System.Data;
using Microsoft.Data.Sqlite;
class Query
{
    private string _testament;
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    private List<string> _verseText = [];

    private List<string[]> RunQuery(string query)
    {
        string connectionString = "Data Source=kjv.db";

        List<string[]> results = [];

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = query;
            
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string[] row = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }
                    results.Add(row);
                }
            }
        }
        return results;
    }

    private string GetMenuItems(string query)
    {
        
        List<string[]> allResults = RunQuery(query);
        List<string> menuItems = new();

        foreach (var row in allResults) menuItems.Add(row[0]);

        ConsoleMenu menu = new ConsoleMenu(menuItems);
        string selection = menu.DisplayMenu();

        return selection;
    }

    public void TestamentSelect()
    {
        string query = """
            SELECT 
                DISTINCT Testament 
            FROM kjv
        """;
        Console.WriteLine("Select a Testament:");
        _testament = GetMenuItems(query);
    }

    public void BookSelect()
    {
        string query = $"""
            SELECT 
                DISTINCT Book 
            FROM kjv 
            WHERE 
                Testament = '{_testament}'
        """;
        Console.WriteLine("Select a book:");
        _book = GetMenuItems(query);
    }

    public void ChapterSelect()
    {
        string query = $"""
            SELECT 
                DISTINCT Chapter 
            FROM kjv 
            WHERE 
                Testament = '{_testament}' 
                AND Book = '{_book}'
            """;
        Console.WriteLine("Select a chapter:");
        _chapter = GetMenuItems(query);
    }

    public void VerseSelect()
    {
        Console.Clear();
        Console.CursorVisible = true;
        string query = $"""
            SELECT 
                MAX(Verse) 
            FROM kjv 
            WHERE 
                Testament = '{_testament}' 
                AND Book = '{_book}' 
                AND Chapter = '{_chapter}'
            """;
        List<string[]> verseLength = RunQuery(query);
        Console.WriteLine($"Select a verse or a range of verses between 1 and {verseLength[0][0]}:");
        Console.Write("Verse start: ");
        _verseStart = Console.ReadLine();
        Console.Write("Verse end (optional): ");
        _verseEnd = Console.ReadLine();
    }

    public void GetVerseText()
    {
        string query = $"""
            SELECT 
                Text 
            FROM kjv 
            WHERE 
                Testament = '{_testament}' 
                AND Book = '{_book}' 
                AND Chapter = '{_chapter}' 
                AND Verse BETWEEN {_verseStart} 
                    AND {_verseEnd}
            """;
        List<string[]> verseText = RunQuery(query);
        foreach(string[] verse in verseText) _verseText.Add(verse[0]);
    }
}
            