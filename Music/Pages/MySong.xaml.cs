using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Music.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MySong : Page
    {
        private ObservableCollection<Song> ListSongs { get; set; }
        private SongService songService;
        public static GridView MyList;
        public MySong()
        {
            this.InitializeComponent();
                 MyList = this.MyListSong;
                songService = new SongServiceImp();
                this.ListSongs = new ObservableCollection<Song>();
            
                List<Song> listSong = songService.GetMySongs();
                if (listSong != null)
                {
                    Naview.MySongs = listSong;
                    this.loginRequied.Visibility = Visibility.Collapsed;
                    foreach (Song item in listSong)
                    {
                        this.ListSongs.Add(new Song()
                        {
                            name = item.name,
                            singer = item.singer,
                            thumbnail = item.thumbnail,
                            link = item.link
                        });
                    }

                    if (Naview.listPlaying.Equals("MY_SONG"))
                    {
                        MyListSong.SelectedIndex = Naview._currentIndex;
                    }
                }
                else
                {
                    this.loginRequied.Visibility = Visibility.Visible;
                }
                
        }

        

        private void MyListSong_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var song = e.ClickedItem as Song;
            Debug.WriteLine(song.name);
            Naview.MyMediaPlayer.Source = new Uri(song.link);
            Naview._isPlay = true;
            Naview.listPlaying = "MY_SONG";
            Naview._currentIndex = ListSongs.IndexOf(song);
            Naview.NamePlaying.Text = song.name;
            Naview.btnStatus.Icon = new SymbolIcon(Symbol.Pause);
            Debug.WriteLine(ListSongs.IndexOf(song));
        }

        private async void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            //Naview.MainFrame.Navigate(typeof(Login));
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
