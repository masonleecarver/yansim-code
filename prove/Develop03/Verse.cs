public class Verse
{
    public string _heading = "";
    public List<Word> _verse = new();

    public Verse(string heading, List<Word> verse)
    {
        _heading = heading;
        _verse = verse;
    }
}