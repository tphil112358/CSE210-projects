class Program
{
    static void Display(Reference reference, Scripture scripture)
    {
        Console.Clear();
        reference.Display();
        scripture.Display();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
    }
    static void Main(string[] args)
    {
        var _reference = new Reference("Jacob",6,10,11);
        var _scripture = new Scripture("O then, my beloved brethren, repent ye, and enter in at the strait gate, and continue in the way which is narrow, until ye shall obtain eternal life. O be wise; what can I say more?");
        Display(_reference,_scripture);

        while (true)
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            _scripture.HideRandomWord();
            if (_scripture.AllWordsHidden() == true) 
            {
                Display(_reference,_scripture);
                break;
            }
            else
            {   
                Display(_reference,_scripture);
            }
        }
    }
}