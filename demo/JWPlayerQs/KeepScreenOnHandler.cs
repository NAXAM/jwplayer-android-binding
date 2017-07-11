using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Longtailvideo.Jwplayer.Events.Listeners;
using Com.Longtailvideo.Jwplayer;
using Com.Longtailvideo.Jwplayer.Core;
using Com.Longtailvideo.Jwplayer.Events;

namespace JWPlayerQs
{
    public class KeepScreenOnHandler : Java.Lang.Object,
        IVideoPlayerEventsOnPlayListener,
         IVideoPlayerEventsOnPauseListener,
         IVideoPlayerEventsOnCompleteListener,
         IVideoPlayerEventsOnErrorListenerV2,
         IAdvertisingEventsOnAdPlayListenerV2,
         IAdvertisingEventsOnAdPauseListenerV2,
         IAdvertisingEventsOnAdCompleteListenerV2,
         IAdvertisingEventsOnAdSkippedListenerV2,
         IAdvertisingEventsOnAdErrorListener
    {
        private Window mWindow;
        public KeepScreenOnHandler(JWPlayerView jwPlayerView, Window window)
        {
            jwPlayerView.AddOnPlayListener(this);
            jwPlayerView.AddOnPauseListener(this);
            jwPlayerView.AddOnCompleteListener(this);
            jwPlayerView.AddOnErrorListener(this);
            jwPlayerView.AddOnAdPlayListener(this);
            jwPlayerView.AddOnAdPauseListener(this);
            jwPlayerView.AddOnAdCompleteListener(this);
            jwPlayerView.AddOnAdErrorListener(this);
            mWindow = window;
        }
        private void UpdateWakeLock(bool enable)
        {
            if (enable)
            {
                mWindow.AddFlags(WindowManagerFlags.KeepScreenOn);
            }
            else
            {
                mWindow.ClearFlags(WindowManagerFlags.KeepScreenOn);
            }
        }


        public void OnPlay(PlayerState oldState)
        {
            UpdateWakeLock(true);
        }

        public void OnPause(PlayerState oldState)
        {
            UpdateWakeLock(false);
        }

        public void OnComplete()
        {
            UpdateWakeLock(false);
        }

        public void OnAdError(String tag, String message)
        {
            UpdateWakeLock(false);
        }

        public void OnError(ErrorEvent errorEvent)
        {
            UpdateWakeLock(false);
        }

        public void OnAdPlay(AdPlayEvent adPlayEvent)
        {
            UpdateWakeLock(true);
        }

        public void OnAdPause(AdPauseEvent adPauseEvent)
        {
            UpdateWakeLock(false);
        }

        public void OnAdComplete(AdCompleteEvent adCompleteEvent)
        {
            UpdateWakeLock(false);
        }

        public void OnAdSkipped(AdSkippedEvent adSkippedEvent)
        {
            UpdateWakeLock(false);
        }
    }
}