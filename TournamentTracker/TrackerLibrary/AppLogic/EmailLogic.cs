using System.Net.Mail;

namespace TrackerLibrary.AppLogic
{
    internal class EmailLogic
    {
        public static void SendMail(string to, string subject, string body)
        {
            MailAddress fromMail = new(GlobalConfig.AppKeyLookup("SenderMail"));
            MailMessage message = new()
            {
                From = fromMail,
                Subject = subject,
                Body = body
            };

            message.To.Add(to);

            string host = "localhost";
            int port = 25;

            SmtpClient smtp = new(host, port);

            smtp.Send(message);
        }
    }
}
