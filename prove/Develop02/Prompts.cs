public class Promts
{
    static Random random = new Random();
    public List<string> _promptList = new List<string> {
        "What are you grateful for today?",
            "Who are you grateful for today?",
            "What went well today? What was difficult? Why?",
            "What did you learn today?",
            "What goals did you set today?",
            "What do you love about yourself? What compliments can you give yourself?",
            "How are you feeling today? What makes you feel that way?",
            "How do you want to feel? Why?",
            "What are you looking forward to this week? Why?",
            "What is something that has made you happy recently?",
            "What's the best thing that could happen tomorrow?",
            "What have you accomplished recently that you are proud of?",
            "What would people say are your best qualities?",
            "What's your happy place? Why?",
            "What's the kindest thing someone has done for you recently?",
            "What can you see / hear / smell / feel right now?",
            "What's on your worry list right now? What can you do about it?",
            "Who do you admire? Why?",
            "What is something in your life that you would like to change?",
            "Describe how you would like your life to look in 5 years.",
            "What difficult thing have you been through recently that brought unexpected positives?",
            "What would you do if you knew you couldn't fail?"
    };

    public string RandomPrompt()
    {
        string prompt = _promptList[random.Next(_promptList.Count)];
        return prompt;
    }
}