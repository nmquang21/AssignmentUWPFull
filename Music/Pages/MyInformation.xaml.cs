using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Music.Entity;
using Music.Service;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Music.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyInformation : Page
    {
        private MemberService memberService;
        private Member member;
        public MyInformation()
        {

            this.InitializeComponent();
            memberService = new MemberServiceImp();
            member = memberService.GetInformation();
            //if (string.IsNullOrEmpty(member.id))
            //{
            //   
            //}
            //else
            //{
                if (member!=null)
                {
                    this.name.Text = member.firstName + " " + member.lastName;
                    if (member.gender == 0)
                    {
                        this.gender.Text = "Male";
                    }
                    else if (member.gender == 1)
                    {
                        this.gender.Text = "Female";
                    }

                    DateTime dt = DateTime.Parse(member.birthday);
                    this.birthday.Text = String.Format("{0:MM/dd/yyyy}", dt);
                    this.loginRequied.Visibility = Visibility.Collapsed;
            }
                else
                {
                    this.info.Visibility = Visibility.Collapsed;
                    this.loginRequied.Visibility = Visibility.Visible;
                }
            //}
        }

        private void ButtonLogout_OnClick(object sender, RoutedEventArgs e)
        {
            memberService.logout();
            Naview.MainFrame.Navigate(typeof(MyInformation));
            Naview.loginItem.Visibility = Visibility.Visible;
            Naview.registerItem.Visibility = Visibility.Visible;
            Naview.myInfoItem.Visibility = Visibility.Collapsed;
        }
        private async void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            SignInContentDialog signInDialog = new SignInContentDialog();
            await signInDialog.ShowAsync();
        }
        private async void ButtonRegister_OnClick(object sender, RoutedEventArgs e)
        {
            RegisterContentDialog registerDialog = new RegisterContentDialog();
            await registerDialog.ShowAsync();
        }
    }
}
