﻿namespace EmailSendTest.EmailService
{
    /// <summary>
    /// Email 配置类
    /// </summary>
    public class EmailConfig
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
