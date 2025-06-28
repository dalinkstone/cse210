public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        foreach (string s in text.Split(" "))
        {
            _words.Add(new Word(s));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randNumber = new Random();
	
	int wordsVisible = 0;

	foreach (Word w in _words)
	{
		if (w.IsHidden() == false)
		{
			wordsVisible++;
		}
	}

	int availableToHide = Math.Min(numberToHide, wordsVisible);

        for (int i = 0; i < availableToHide; i++)
        {
            int randomNumber = randNumber.Next(_words.Count);

            if (_words[randomNumber].IsHidden() == false)
            {
                _words[randomNumber].Hide();
            }
            else
            {
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        string _scriptureText = "";

        foreach (Word word in _words)
        {
            _scriptureText += word.GetDisplayText() + " ";
        }
        return _scriptureText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
