using System.Linq;

public class Word
{
    string _word = "";
    bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public void Hide()
    {

        if (_isHidden == false)
        {
            _word = new string('_', _word.Length);
            _isHidden = true;
        }

    }
    public string Show()
    {
        return _word;
    }

    public bool Hidden()
    {
        return _isHidden;
    }

}