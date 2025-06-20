public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random number = new Random();
        int randomNumber = number.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}
