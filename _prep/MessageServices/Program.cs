var services = new List<IMessageService>{
    new EmailService(),
    new SmsService()
};
NotificationManager.NotifyAll(services, "David", "Hello to everyone!");
