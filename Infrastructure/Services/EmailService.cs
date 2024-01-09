using System.Net.Mail;
using System.Threading.Tasks;
using Core.Interfaces.Services;

namespace Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            // This method is a placeholder for actual email sending logic
            // In production, use an email service provider like SendGrid, Mailgun, etc.
            
            using (var smtpClient = new SmtpClient("smtp.example.com"))
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("noreply@example.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(new MailAddress(to));

                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}
```
Please note that this code is a simplified representation of how an email service could be implemented. In a real-world scenario, you would likely use an external email service provider and integrate their SDK or use an API to send emails. Always remember to handle sensitive information such as SMTP server credentials securely.