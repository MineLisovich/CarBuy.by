
using MimeKit;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CarBuy.WEB.Service
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Администрация сайта CarBuy.by", "deelimpay@mail.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 465, true);
                await client.AuthenticateAsync("deelimpay@mail.ru", "uRAxchK0veqpTnjPkMcJ");
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);

            }

        }
    }
}
