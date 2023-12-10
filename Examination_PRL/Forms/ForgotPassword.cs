using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Security.Cryptography;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Text;
using Examination_BUS.Services;

namespace Examination_PRL.Forms
{
    public partial class ForgotPassword : Telerik.WinControls.UI.RadForm
    {


        ParticipantService participantService = new ParticipantService();
        StaffService staffService = new StaffService();
        AccountServices accountServices = new AccountServices();

        public ForgotPassword()
        {
            InitializeComponent();
          
        }

        static async Task Execute(string emailAddress, string FullName, string userName, string password)
        {
            Environment.SetEnvironmentVariable("SENDGRID_API_KEY", "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");
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("hlk9@proton.me", "Testify");
            var subject = "Cấp lại mật khẩu mới cho người dùng " + FullName;
            var to = new EmailAddress(emailAddress, FullName);
            var plainTextContent = "";
            var htmlContent = $"<br>Mật khẩu mới của bạn là: UserName: {userName}<br>Password: <strong>{password}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            await client.SendEmailAsync(msg);

        }

        public string GenerateRandomPassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
        public string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            md5.Clear();
            return sb.ToString();

        }
      
     

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var oneParti = participantService.getAllStudents().Where(x => x.Email == txtEmail.Text).FirstOrDefault();
            var oneStaff = staffService.GetAll().Where(x => x.Email == txtEmail.Text).FirstOrDefault();

            if (oneParti == null && oneStaff == null)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống");
                return;
            }

            if (oneParti != null && oneStaff == null)
            {

                var acc = accountServices.GetAccountById(oneParti.Id);

                var newPassword = GenerateRandomPassword(8);
                var hashedPassword = HashPassword(newPassword);
                acc.Password = hashedPassword;
                var isUpdated = accountServices.UpdateAccount(acc.Id, acc.UserName, acc.Password, null);

                if (isUpdated)
                {
                    Execute(oneParti.Email, oneParti.FullName, oneParti.Id, newPassword).ConfigureAwait(false);
                    MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn\nHãy kiểm tra hộp thư, kể cả thư rác");

                    btnSubmit.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật mật khẩu");
                    return;
                }


            }
            else if (oneParti == null && oneStaff != null)
            {
                var acc = accountServices.GetAccountById(oneStaff.Id);

                var newPassword = GenerateRandomPassword(8);
                var hashedPassword = HashPassword(newPassword);
                acc.Password = hashedPassword;
                var isUpdated = accountServices.UpdateAccount(acc.Id, acc.UserName, acc.Password, null);

                if (isUpdated)
                {
                    Execute(oneStaff.Email, oneStaff.FullName, oneStaff.Id, newPassword).ConfigureAwait(false);
                    MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn\nHãy kiểm tra hộp thư, kể cả thư rác");
                    btnSubmit.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật mật khẩu");
                    return;
                }

            }





        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
