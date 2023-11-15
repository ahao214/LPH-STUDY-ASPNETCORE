using MimeKit;


namespace EmailSendTest.EmailService
{
    /// <summary>
    /// 写信 RFC 822邮件的标准格式
    /// </summary>
    public class EmailMessage
    {

        public MailboxAddress Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public MailboxAddress Reciever { get; set; }

        public MimeMessage CreateEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart()
            {
                Text = message.Content
            };

            return mimeMessage;
        }



    }
}
