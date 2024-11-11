namespace ConsoleApp1;

public class Notification
{
    private EmailService _emailService;

    public Notification()
    {
        _emailService = new EmailService();
    }

    public void Get(string message)
    {
        _emailService.SendEmail(message);
    }
}

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}