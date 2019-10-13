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
    public sealed partial class UploadSongContentDialog : ContentDialog
    {
        private SongService songService;
        private MemberService memberService;
        public UploadSongContentDialog()
        {
            this.InitializeComponent();
            songService = new SongServiceImp();
            memberService = new MemberServiceImp();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            var song = new Song()
            {
                name = this.name.Text,
                description = this.description.Text,
                singer = this.singer.Text,
                author = this.author.Text,
                thumbnail = this.thumbnail.Text,
                link = this.link.Text,
            };
            var errors = new Dictionary<string, string>();
            errors = song.ValidateData();
            if (errors.Count == 0)
            {

                if (!memberService.GetTokenFromLocalStorage().Equals(""))
                {
                    songService.UploadSong(song);
                    Naview.MainFrame.Navigate(typeof(MySong));
                }
                else
                {
                    var respSong = songService.UploadFreeSong(song);
                    Reset();
                    this.name_validate.Visibility = Visibility.Collapsed;
                    this.link_validate.Visibility = Visibility.Collapsed;
                    this.thumbnail_validate.Visibility = Visibility.Collapsed;
                    this.singer_validate.Visibility = Visibility.Collapsed;
                    this.upload_state.Text = "Upload Song " + respSong.name + " Success!";
                    args.Cancel = true;
                }
            }
            else
            {
                ValidateSongUpload(errors);
                args.Cancel = true;
            }
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Reset();
            args.Cancel = true;
        }

        private void UploadSongContentDialog_OnCloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Debug.WriteLine("Cancel");
        }
        private void Reset()
        {
            this.name.Text = string.Empty;
            this.description.Text = string.Empty;
            this.singer.Text = string.Empty;
            this.author.Text = string.Empty;
            this.thumbnail.Text = string.Empty;
            this.link.Text = string.Empty;
            this.link_validate.Text = string.Empty;
            this.name_validate.Text = string.Empty;
            this.singer_validate.Text = string.Empty;
            this.thumbnail_validate.Text = string.Empty;
        }
        private void ValidateSongUpload(Dictionary<string, string> errors)
        {
            if (errors.ContainsKey("name"))
            {
                this.name_validate.Text = errors["name"];
                this.name_validate.Visibility = Visibility;
            }
            else
            {
                this.name_validate.Visibility = Visibility.Collapsed;
            }

            if (errors.ContainsKey("thumbnail"))
            {
                this.thumbnail_validate.Text = errors["thumbnail"];
                this.thumbnail_validate.Visibility = Visibility;
            }
            else
            {
                this.thumbnail_validate.Visibility = Visibility.Collapsed;
            }
            if (errors.ContainsKey("link"))
            {
                this.link_validate.Text = errors["link"];
                this.link_validate.Visibility = Visibility;
            }
            else
            {
                this.link_validate.Visibility = Visibility.Collapsed;
            }

            if (errors.ContainsKey("singer"))
            {
                this.singer_validate.Text = errors["singer"];
                this.singer_validate.Visibility = Visibility;
            }
            else
            {
                this.singer_validate.Visibility = Visibility.Collapsed;
            }
        }
    }
}
