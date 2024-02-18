class Scripture
{
    private List<Word> _words;
    public Scripture(string text)
    {
        string[] _wordTexts = text.Split(" ");
        _words = new List<Word>();
        foreach (string _wordText in _wordTexts)
        {
            _words.Add(new Word(_wordText, false));
        }
    }
    public void HideRandomWord()
    {
        int _thrice = 0;
        while (_thrice != 3)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            while (_words[index].GetIsHidden() == true)
            {
                index = random.Next(_words.Count);
            }
            _words[index].SetIsHidden(true);
            _thrice ++;
        }
    }
    public bool AllWordsHidden()
    {
        return _words.All(word => word.GetIsHidden() == true);
    }

    public void Display()
    {
        foreach (var word in _words)
        {
            if (word.GetIsHidden() == false)
                Console.Write(word.GetText() + " ");
            else
                word.DisplayUnderscores();
        }
    }
}
