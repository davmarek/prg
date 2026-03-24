class NotificationManager
{
    public static void NotifyAll(
        List<IMessageService> services,
        string target,
        string message)
    {
        foreach (var s in services)
        {
            s.SendMessage(target, message);
        }
    }
}
