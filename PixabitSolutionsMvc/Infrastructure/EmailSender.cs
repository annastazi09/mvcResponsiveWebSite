using System.Net.Mail;

namespace PixabitSolutionsMvc.Infrastructure
{
    public class EmailSender
    {
        public static bool SendEmail(string from, string to, string subject, string body)
        {
            using (var email = new MailMessage())
            {
                email.From = new MailAddress(from);
                email.To.Add(new MailAddress(to));
                email.Subject = subject;
                email.Priority = MailPriority.Low;
                email.IsBodyHtml = true;
                email.Body = body;

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Send(email);
                }
            }

            return true;
        }

        public static void SendSystemEmail(string to, string subject, string body)
        {
            using (var email = new MailMessage())
            {
                email.From = new MailAddress(AppSettings.FromEmailAddress);
                email.To.Add(new MailAddress(to));
                email.Subject = subject;
                email.Priority = MailPriority.Low;
                email.IsBodyHtml = true;
                email.Body = body;

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Send(email);
                }
            }
        }
    }
}