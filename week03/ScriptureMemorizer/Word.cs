using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden
    }

    public void Hide() => _isHidden = true; // Method to hide the word
    public bool IsHidden() => _isHidden; // Method to check if the word is hidden
    public string GetDisplayText() => _isHidden ? new string('_', _text.Length) : _text;  // Method to get the text of the word

}
