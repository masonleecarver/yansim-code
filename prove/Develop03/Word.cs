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
            List<char> charList = _word.ToList();

            for (int i = 0; i < charList.Count; i++)
            {
                charList[i] = '_';
            }

            _word = new string(charList.ToArray());

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