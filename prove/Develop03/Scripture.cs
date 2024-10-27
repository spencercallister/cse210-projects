using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Scripture
{
    private List<string> _verseText = [];
    private List<Word> _words = new();

    public Scripture(string scriptureString)
    {
        string[] scriptureList = scriptureString.Split(" ");
        foreach(string word in scriptureList) _words.Add(new Word(word));
    }

    public List<int> RandomHide()
    {
        List<Word> shownWords = _words.Where(word => word.GetHidden() == false).ToList();
        for(int i = 0; i < 3; i++)
        {
            Random random = new();
            int randomIndex = random.Next(0, shownWords.Count);
            shownWords[randomIndex].SetHidden();
            shownWords.RemoveAt(randomIndex);
        }
        // List<int> wordCounts = 
        return [shownWords.Count, _words.Count];
    }

    public void DisplayScripture()
    {
        string output;
        foreach(Word word in _words)
        {
            output = word.GetHidden() == false ? word.GetText():"_";
            Console.Write($"{output} ");
        }
    }
}