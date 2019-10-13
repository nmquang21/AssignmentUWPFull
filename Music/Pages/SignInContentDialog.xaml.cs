using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Music.Entity;
using Music.Service;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Music.Pages
{
    public enum SignInResult
    {
        SignInOK,
        SignInFail,
        SignInCancel,
        Nothing
    }

    public sealed partial class SignInContentDialog : ContentDialog
    {
        public SignInResult Result { get; private set; }
        private MemberService memberService;
        public SignInContentDialog()
        {
            this.InitializeComponent();
            memberService = new MemberServiceImp();
        }
        //args.Cancel = true;

        private async void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            var memberLogin = new MemberLogin()
            {
                email = this.emailTextBox.Text,
                password = this.passwordTextBox.Password,
            };
            var errors = new Dictionary<string, string>();
            errors = memberLogin.ValidateData();
            if (errors.Count == 0)
            {
                if (memberService.Login(memberLogin) != null)
                {
                    Naview.MainFrame.Navigate(typeof(MyInformation));
                    Naview.loginItem.Visibility = Visibility.Collapsed;
                    Naview.registerItem.Visibility = Visibility.Collapsed;
                    Naview.myInfoItem.Visibility = Visibility.Visible;
                    this.Result = SignInResult.SignInOK;
                }
                else
                {
                    this.login_fail.Text = "Wrong login information!!";
                    this.login_fail.Visibility = Visibility.Visible;
                    this.validate_email.Visibility = Visibility.Collapsed;
                    this.validate_password.Visibility = Visibility.Collapsed;
                    args.Cancel = true;
                }
            }
            else
            {
                ValidateLogin(errors);
                args.Cancel = true;
            }

        }

        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // User clicked Cancel, ESC, or the system back button.
            this.Result = SignInResult.SignInCancel;
        }
        private void ValidateLogin(Dictionary<string, string> errors)
        {
            if (errors.ContainsKey("email"))
            {
                this.validate_email.Text = errors["email"];
                this.validate_email.Visibility = Visibility.Visible;
            }
            else
            {
                this.validate_email.Visibility = Visibility.Collapsed;
            }
            if (errors.ContainsKey("password"))
            {
                this.validate_password.Text = errors["password"];
                this.validate_password.Visibility = Visibility.Visible;
            }
            else
            {
                this.validate_password.Visibility = Visibility.Collapsed;
            }
        }
    }
}
