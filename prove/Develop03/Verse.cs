public class Verse
{
    string _heading = "";
    List<Word> _verse = new();

    public Verse(string heading, List<Word> verse)
    {
        _heading = heading;
        _verse = verse;
    }

    public string GetHeading()
    {
        return _heading;
    }

    public List<Word> GetVerse()
    {
        return _verse;
    }
}