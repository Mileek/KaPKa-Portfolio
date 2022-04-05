using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace KaPKa.Models
{
    public class ContactModel
    {
        public string fromName { get; set; }
        public string fromEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public void Send(string fromName, string fromEmail, string mailSubject, string message)
        {
            // create message object
            var messageData = new MimeMessage();
            //who will send the message
            messageData.From.Add(new MailboxAddress(fromName, fromEmail));
            //To whom send the mail
            messageData.To.Add(MailboxAddress.Parse("kapkasender@gmail.com"));
            //Messge subject
            messageData.Subject = mailSubject;
            //Message body
            messageData.Body = new TextPart(TextFormat.Plain) { Text = message };

            // send email
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                // Note: only needed if the SMTP server requires authentication
                

                client.Send(messageData);
                client.Disconnect(true);

            }
        }
    }
}
