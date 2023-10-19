public class Word
{
    private string Text;
    private bool Hidden;

    //Constructor
    public Word(string text, bool hidden)
    {
        Text = text;
        Hidden = hidden;
    }

    //Methods
    public void Hide()
    {
        Hidden = true;
    }
    public void Show()
    {
        Hidden = false;
    }
    public bool IsHidden()
    {
        return Hidden;
    }
    public string GetRenderedText()
    {
        return Hidden ?  "___": Text;
    }
}