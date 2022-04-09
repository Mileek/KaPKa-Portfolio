using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.ComponentModel.DataAnnotations;

namespace KaPKa.Models
{
    public class ContactModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name needs to be longer than 3 characters.")]
        [Display(Name = "Name")]
        public string? fromName { get; set; }
        [Required]
        [EmailAddress]
        [MinLength(6, ErrorMessage = "Email needs to be longer than 6 characters.")]
        [Display(Name = "Email")]
        public string? fromEmail { get; set; }
        public string? Topic { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Message needs to be longer than 10 characters.")]
        [Display(Name = "Message")]
        public string? Message { get; set; }

        public void Send(string fromName, string fromEmail, string mailTopic, string message)
        {
            // create message object
            var messageData = new MimeMessage();
            //who will send the message
            messageData.From.Add(new MailboxAddress(fromName, fromEmail));
            //To whom send the mail
            messageData.To.Add(MailboxAddress.Parse("system@kamil-p-kaszuba.pl"));
            //Messge subject
            messageData.Subject = mailTopic;
            //Message body
            messageData.Body = new TextPart(TextFormat.Plain) { Text = message };

            // send email
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.webio.pl", 587, SecureSocketOptions.StartTls);

                client.Send(messageData);
                client.Disconnect(true);

            }
        }
    }
}
