using StudentManager.Data.DAC;
using StudentManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Service.Service
{
    public class LoginService : ILogin
    {
        public bool LoginCheck(string id, string pw)
        {
            int emp_no;

            if (!int.TryParse(id, out emp_no))
                return false;
            
            LoginDAC dac = new LoginDAC();
            bool result = dac.GetLoginInfo(emp_no, pw) > 0;
            dac.Dispose();

            return result;
        }

        public bool SendEmail(string recipient)
        {            
            string sender = ConfigurationManager.AppSettings["email"]; // 보내는 메일
            string password = ConfigurationManager.AppSettings["emailPw"]; // 메일 비밀번호

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(sender, "[강지훈] 학원 관리 프로그램", Encoding.UTF8);

            mail.To.Add(recipient);

            mail.Subject = "임시 비밀번호 안내";
            mail.Body = "ㅎㅇ <h1>~~~</h1>";
            mail.IsBodyHtml = true;

            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding= Encoding.UTF8;

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(sender, password);
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception err)
            {
                Debug.WriteLine(sender);
                Debug.WriteLine(password);
                Debug.WriteLine(recipient);
                Debug.WriteLine(err.Message);
                return false;
            }

            return true;
        }
    }
}
;