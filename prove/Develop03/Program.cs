using System;

class Program
{
    static void Main(string[] args)
    {
        Reference one = new Reference("And I said unto him: I know that he loveth his children; nevertheless, I do not know the meaning of all things.", "1 Nephi", 11, 17);
        Reference two = new Reference("Nevertheless, Jacob, my first-born in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.", "2 Nephi", 2, 1, 2);
        Scripture penny = new Scripture(new List<Reference> {one, two});

        penny.OriginalText();
        string input;

        do 
        {
            input = Console.ReadLine();
            // var key = Console.ReadKey(true);
            if (input == "quit" || penny.HiddenStatus() == true)
            {
                break;
            }
            else
            {
                penny.GetRenderedText();
            }
        }
        while (input != "quit" || penny.HiddenStatus() == false);
        
    }
}