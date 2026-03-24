
class EmailService : IMessageService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"Sending Email to {target} with text: {message}");
    }
}
