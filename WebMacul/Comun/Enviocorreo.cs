using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;


namespace WebMacul.Comun
{
    public class Enviocorreo
    {
        MailMessage M = new MailMessage();
        SmtpClient Smtp = new SmtpClient();

        public bool Enviarcorreo(string from,string pass,string to,string msg)
        {
            try
            {
                M.From = new MailAddress(from);
                M.To.Add(new MailAddress(to));
                M.Body = msg;
                M.Subject = "Registro de Funcionario";
                Smtp.Host = "smtp.gmail.com";
                Smtp.Port = 587;
                Smtp.Credentials = new NetworkCredential(from,pass);
                Smtp.EnableSsl = true;
                Smtp.Send(M);
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }

        }

    }
}