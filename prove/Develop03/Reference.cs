class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book,int chapter,int verseStart,int verseEnd)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseStart = verseStart;
        this._verseEnd = verseEnd;
    }
    public Reference(string book,int chapter,int verseStart)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseStart = verseStart;
        _verseEnd = 0;
    }
    public void Display()
    {
        if (_verseEnd != 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        }
    }
}

