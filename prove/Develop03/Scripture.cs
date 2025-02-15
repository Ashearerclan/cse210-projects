using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private List<(Reference, string)> _scriptures;
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture()
    {
        _scriptures = new List<(Reference, string)>();
    }

    public void LoadScriptures()
    {
        _scriptures.Add((new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        _scriptures.Add((new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        _scriptures.Add((new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."));
    }

    public void SelectRandomScripture()
    {
        var selected = _scriptures[_random.Next(_scriptures.Count)];
        _reference = selected.Item1;
        _words = selected.Item2.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string RenderScripture()
    {
        return _reference.GetDisplayText() + "\n" + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
}
