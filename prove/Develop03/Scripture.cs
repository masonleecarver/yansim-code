using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

public class Scripture
{
    List<Reference> _references = new();
    List<Verse> _verses = new();

    List<Word> _words = new();
    bool isCompletelyHidden = false;
    List<Word> nonHiddenWords = new();
    Random random = new();

    public Scripture(List<Reference> references)
    {
        _references = references;
        HandleReference();
    }

    private void HandleReference()
    {
        foreach (Reference reference in _references)
        {
            string verse = reference.Verse();
            string heading = reference.MakeHeading();
            List<Word> wordsList = new();

            string[] words = verse.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Word wordObject = new Word(word);
                _words.Add(wordObject);
                wordsList.Add(wordObject);
            }

            _verses.Add(new Verse(heading, wordsList));
        }
    }

    public void OriginalText()
    {
        foreach (Verse verse in _verses)
        {
            string renderedText = string.Join(" ", verse.GetVerse().Select(word => word.Show()));
            Console.Write($"\n{verse.GetHeading()}: {renderedText}");
        }

        Console.Write($"\n\n(Non-Hidden Words Remaining: {_words.Count}) Press enter to continue. Enter \"quit\" to quit. ");
    }

    private List<Word> GetNonHiddenWords()
    {
        return _words.Where(word => !word.Hidden()).ToList();
    }
    private void Render()
    {
        nonHiddenWords = GetNonHiddenWords();

        if (nonHiddenWords.Count < 3)
        {
            foreach (Word word in nonHiddenWords)
            {
                word.Hide();
            }

            isCompletelyHidden = true;

            nonHiddenWords = GetNonHiddenWords();

            return;
        }

        var selectedWords = nonHiddenWords.OrderBy(x => random.Next()).Take(3).ToList();

        foreach (Word word in selectedWords)
        {
            word.Hide();
        }

        nonHiddenWords = GetNonHiddenWords();
    }

    public bool HiddenStatus()
    {
        return isCompletelyHidden;
    }

    public void GetRenderedText()
    {
        Render();
        // for (int i=0; i < _verses.Count + 1; i++)
        // {
        //     Console.SetCursorPosition(0, Console.CursorTop -1);
        //     Console.Write(new string(' ', Console.WindowWidth));
        // }   
        // Console.SetCursorPosition(0, Console.CursorTop - _verses.Count + 1);

        Console.Clear();
        Console.SetCursorPosition(0, 0);

        foreach (Verse verse in _verses)
        {
            string renderedText = string.Join(" ", verse.GetVerse().Select(word => word.Show()));
            Console.WriteLine($"{verse.GetHeading()}: {renderedText}".PadRight(Console.WindowWidth));
        }
        Console.Write($"\n\n(Non-Hidden Words Remaining: {nonHiddenWords.Count}) Press enter to continue. Enter \"quit\" to quit. ");
    }

}