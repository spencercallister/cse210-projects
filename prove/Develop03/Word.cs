class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }

    public void SetHidden()
    {
        _isHidden = true;
    }
}