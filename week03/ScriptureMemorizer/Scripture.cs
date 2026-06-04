using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _word;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = new List<Word>();
        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            Word w = new Word(part);
            _word.Add(w);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && HasVisibleWord())
        {
            int index = rand.Next(_word.Count);
            if (!_word[index].IsHidden())
            {
                _word[index].Hide();
                hiddenCount++;
            }
        }
        
    }
    private bool HasVisibleWord()
    {
        foreach (Word w in _word)
        {
            if (!w.IsHidden())
            {
                return true;
            }
        }
        return false;
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordText = "";
        foreach (Word w in _word)
        {
            wordText += w.GetDisplayText() + " ";
        }

        return $"{referenceText} - {wordText.Trim()}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _word)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}