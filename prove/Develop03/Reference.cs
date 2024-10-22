using System.Data;

public class Reference
{
    string _book = "";
    int _chapter;
    int _firstVerse;
    int _lastVerse;
    string _verse = "";

    public Reference(string verse, string book, int chapter, int firstVerse)
    {
        _verse = verse;
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }

    public Reference(string verse, string book, int chapter, int firstVerse, int lastVerse)
    {
        _verse = verse;
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string MakeHeading()
    {
        if (_lastVerse != 0)
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
    }

    public string Verse()
    {
        return _verse;
    }

}