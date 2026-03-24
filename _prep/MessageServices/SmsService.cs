class SmsService : IMessageService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"Sending SMS to {target} with text: {message}");
    }
}
