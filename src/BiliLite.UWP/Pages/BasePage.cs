﻿using System.Threading.Tasks;
using BiliLite.Controls;
using BiliLite.Models.Common;
using BiliLite.Services;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BiliLite.Pages
{
    public class BasePage : Page
    {
        public string Title { get; set; }
        public BasePage()
        {
            this.NavigationCacheMode = (SettingService.GetValue<int>(SettingConstants.UI.DISPLAY_MODE, 0) == 1) ? Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled : Windows.UI.Xaml.Navigation.NavigationCacheMode.Disabled;
        }
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back || e.SourcePageType == typeof(BlankPage))
            {
                this.NavigationCacheMode = NavigationCacheMode.Disabled;
            }

            base.OnNavigatingFrom(e);
        }
    }

    public class PlayPage : BasePage
    {
        public PlayerControl Player { get; set; }

        public bool IsPlaying => Player.IsPlaying;

        public void Pause()
        {
            Player.PlayerInstance.Pause();
        }
        public void Play()
        {
            Player.PlayerInstance.Play();
        }

        public void GotoLastVideo()
        {
            Player.GotoLastVideo();
        }

        public void GotoNextVideo()
        {
            Player.GotoNextVideo();
        }

        public void SlowDown()
        {
            Player.SlowDown();
        }

        public void FastUp()
        {
            Player.FastUp();
        }

        public void ToggleMute()
        {
            Player.ToggleMute();
        }

        public void StartHighRateSpeedPlay()
        {
            Player.StartHighRateSpeedPlay();
        }

        public void StopHighRateSpeedPlay()
        {
            Player.StopHighRateSpeedPlay();
        }

        public void PositionBack()
        {
            Player.PositionBack();
        }

        public void PositionForward(double progress = 3)
        {
            Player.PositionForward(progress);
        }

        public void ToggleMiniWindows()
        {
            Player.ToggleMiniWindows();
        }

        public void ToggleFullWindow()
        {
            Player.ToggleFullWindow();
        }

        public void ToggleFullscreen()
        {
            Player.ToggleFullscreen();
        }

        public async Task CaptureVideo()
        {
            await Player.CaptureVideo();
        }

        public void ToggleDanmakuDisplay()
        {
            Player.ToggleDanmakuDisplay();
        }

        public void AddVolume()
        {
            Player.AddVolume();
        }

        public void MinusVolume()
        {
            Player.MinusVolume();
        }

        public void CancelFullscreen()
        {
            Player.CancelFullscreen();
        }

        public void DisposePlayer()
        {
            Player?.Dispose();
        }

        public void Seek(double position)
        {
            Player.SetPosition(position);
        }

        public async Task ReportHistory()
        {
            if (Player == null) return;
            await Player.ReportHistory();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back || e.SourcePageType == typeof(BlankPage))
            {
                // (this.Content as Grid).Children.Clear();
                //  GC.Collect();
            }
            base.OnNavigatingFrom(e);
        }
    }

}
