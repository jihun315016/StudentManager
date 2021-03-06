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
        /// <summary>
        /// 로그인 체크
        /// 결과값이 0보다 크면 로그인 성공
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 메일 전송
        /// </summary>
        /// <param name="name">수신자 이름</param>
        /// <param name="recipient">수신자 메일</param>
        /// <param name="newPassword">새로운 임시 비밀번호</param>
        /// <returns></returns>
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

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
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

        /// <summary>
        /// 임시 비밀번호 제작
        /// a ~ z, 0 ~ 9 까지의 조합으로 만들어 리턴한다.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 메일 전송 폼
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        string GetPassworkMessage(string name, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<strong>{name}</strong>님 안녕하세요.<br>");
            sb.Append("임시 비밀번호 발급 안내입니다.<br>");
            sb.Append("로그인 후, '내 정보'에서 비밀번호를 변경하여 주시기 바랍니다.");
            sb.Append($"<h1>임시 비밀번호 : {password}</h1>");

            return sb.ToString();
        }

        /// <summary>
        /// 비밀번호 변경
        /// </summary>
        /// <param name="emp_no">변경 직원 번호</param>
        /// <param name="newPassword">새로운 비밀번호</param>
        /// <returns></returns>
        public bool ChangePassword(int emp_no, string newPassword)
        {
            LoginDAC dac = new LoginDAC();
            bool result = dac.ChangePassword(emp_no, newPassword);
            dac.Dispose();

            return result;
        }
    }
};