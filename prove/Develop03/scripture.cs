public class Scripture
{
    private List<Word> Words {get;}
    private Reference Reference {get;}
    
    //Constructor
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Words.Add(new Word(wordText, false));
        }
    }

    public void HideWords()
    {
        foreach (Word word in Words)
        {
            word.Hide();
        }
    }

    public string GetRenderedText()
    {
        List<string> renderWords = new List<string>();
        foreach (Word word in Words)
        {
            renderWords.Add(word.GetRenderedText());
        }
        return string.Join(" ", renderWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in Words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public List<Word> GetWords()
    {
        return Words;
    }
}