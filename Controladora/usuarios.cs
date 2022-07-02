using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;
using System.Net;
using System.Net.Mail;
namespace Controladora
{
    public class usuarios
    {
        public int identificador (string usuarios, string contrasena) 
        {
            if(usuarios == "admin" && contrasena == "Osonegro123")
            {
                return 1;
            }
            return -1;
        }

        public MailMessage Mail_Registro(string usuario_mail, string usuario_nombre, string usuario_apellido)
        {
            MailMessage correo = new MailMessage();

            correo.To.Add(usuario_mail);
            correo.Subject = "Registro completo con exito";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "Usted, " + usuario_nombre + " " + usuario_apellido + ", se registro exitosamente en la plataforma";
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("sanchezautomotoroficial@outlook.com");

            return correo;
        }

        public SmtpClient SmtpClient()
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Credentials = new System.Net.NetworkCredential("sanchezautomotoroficial@outlook.com", "sanchezautomotores1");

            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.office365.com";

            return smtpClient;
        }


    }

    



}
