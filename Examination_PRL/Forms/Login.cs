using Examination_BUS.Services;
using Examination_DAL.Models;
using Examination_PRL.Forms.Participant;
using Examination_PRL.Forms.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        UserPermissionServices userPermissionServices = new UserPermissionServices();
        AccountServices accountServices = new AccountServices();
        public Login()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyPress += btnLogin_KeyPress;
        }

        private bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                Account account = new Account();
                account = accountServices.GetAccountById(txtUserName.Text);
                if (account != null)
                {
                    if (account.Password != txtPassword.Text)
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return;
                    }

                    account.LastLogin = DateTime.Now;
                    accountServices.UpdateAccount(account.Id, account.UserName, account.Password, Convert.ToDateTime(account.LastLogin));

                    List<UserPermission> userPermissions = new List<UserPermission>();
                    userPermissions = userPermissionServices.GetUserPermissionByAccountID(account.Id);

                    foreach (var item in userPermissions)
                    {
                        if (item.PermissionId == 1)
                        {
                            Dashboard dashboard = new Dashboard(account);
                            dashboard.FormClosed += Dashboard_FormClosed;
                            dashboard.Show();
                            this.Hide();
                            return;
                        }
                    }

                    Dashboard_P dashboard_P = new Dashboard_P(account.UserName, account);
                    dashboard_P.FormClosed += Dashboard_FormClosed;
                    dashboard_P.Show();
                    this.Hide();
                    return;

                }

            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
