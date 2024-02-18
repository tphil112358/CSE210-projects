class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text,bool isHidden)
    {
        this._text = text;
        this._isHidden = isHidden;
    }
    public string GetText()
    {
        return _text;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void SetIsHidden(bool setter)
    {
        _isHidden = setter;
    }
    public void DisplayUnderscores()
    {
        foreach (char c in _text)
        {
            if (char.IsLetter(c))
                Console.Write("_");
            else
                Console.Write(c);
        }
        Console.Write(" ");
    }
}

