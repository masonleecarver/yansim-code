using System.Linq;

public class Word
{
    string _word = "";
    bool isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public void Hide()
    {

        if (isHidden == false)
        {
            _word = new string('_', _word.Length);
            isHidden = true;
        }

    }
    public string Show()
    {
        return _word;
    }

    public bool Hidden()
    {
        return isHidden;
    }

}