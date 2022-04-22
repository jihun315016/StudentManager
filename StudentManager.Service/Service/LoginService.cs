using StudentManager.Data.DAC;
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

namespace StudentManager.Service.Service
{
    public class LoginService
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

        public bool SendEmail(string name, string recipient, string newPassword)
        {            
            string sender = ConfigurationManager.AppSettings["email"]; // 보내는 메일
            string password = ConfigurationManager.AppSettings["emailPw"]; // 메일 비밀번호

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(sender, "[강지훈] 학생 관리 프로그램", Encoding.UTF8);

            mail.To.Add(recipient);

            mail.Subject = "임시 비밀번호 안내";
            mail.Body = GetPassworkMessage(name, newPassword);
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
                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(sender);
                Debug.WriteLine(password);
                Debug.WriteLine(recipient);
                Debug.WriteLine(err.Message);
                return false;
            }

            return false;
        }        


        public string MakePassword()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    sb.Append(rnd.Next(10).ToString());
                }
                else
                {
                    sb.Append(((char)rnd.Next('a', 'z' + 1)).ToString());
                }
            }

            return sb.ToString();
        }

        public bool ChangePassword(int emp_no, string newPassword)
        {
            LoginDAC dac = new LoginDAC();
            bool result = dac.ChangePassword(emp_no, newPassword);
            dac.Dispose();

            return result;
        }

        string GetPassworkMessage(string name, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<strong>{name}</strong>님 안녕하세요.<br>");
            sb.Append("임시 비밀번호 발급 안내입니다.<br>");
            sb.Append("로그인 후, '내 정보'에서 비밀번호를 변경하여 주시기 바랍니다.");
            sb.Append($"<h1>임시 비밀번호 : {password}</h1>");

            return sb.ToString();
        }
    }
};