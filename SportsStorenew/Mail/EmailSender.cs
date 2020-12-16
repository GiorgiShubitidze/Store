using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SportsStorenew.Mail
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {

                var senderEmail = new MailAddress("Giorgi.shubitidze025@gmail.com", "SportsStore");
                var receiverEmail = new MailAddress(email, "Receiver");
                var password = "Aversi77";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                //using (var mess = new MailMessage(senderEmail, receiverEmail)
                //{
                //    Subject = subject,
                //    Body = htmlMessage

                //})


                    //smtp.Send(mess);
                    return smtp.SendMailAsync(new MailMessage(senderEmail, receiverEmail) { Subject = subject, Body=htmlMessage}) ;


            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
           

        }
    }
}
