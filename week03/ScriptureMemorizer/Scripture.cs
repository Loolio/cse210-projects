using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var rnd = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var wordsToHide = visibleWords.OrderBy(x => rnd.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
