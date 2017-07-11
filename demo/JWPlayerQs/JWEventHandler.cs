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
using Com.Longtailvideo.Jwplayer.Core;
using System.Collections.Generic;
using Com.Longtailvideo.Jwplayer.Media.Adaptive;
using Com.Longtailvideo.Jwplayer.Media.Playlists;
using Com.Longtailvideo.Jwplayer.Media.Meta;
using Com.Longtailvideo.Jwplayer.Media.Captions;
using Com.Longtailvideo.Jwplayer.Events.Listeners;
using Com.Longtailvideo.Jwplayer.Media.Audio;
using Com.Longtailvideo.Jwplayer;

namespace JWPlayerQs
{
    public class JWEventHandler : Java.Lang.Object,
        IVideoPlayerEventsOnSetupErrorListener,
        IVideoPlayerEventsOnPlaylistListener,
        IVideoPlayerEventsOnPlaylistItemListener,
        IVideoPlayerEventsOnPlayListener,
        IVideoPlayerEventsOnPauseListener,
        IVideoPlayerEventsOnBufferListener,
        IVideoPlayerEventsOnIdleListener,
        IVideoPlayerEventsOnErrorListener,
        IVideoPlayerEventsOnSeekListener,
        IVideoPlayerEventsOnTimeListener,
        IVideoPlayerEventsOnFullscreenListener,
        IVideoPlayerEventsOnQualityLevelsListener,
        IVideoPlayerEventsOnQualityChangeListener,
        IVideoPlayerEventsOnAudioTracksListener,
        IVideoPlayerEventsOnAudioTrackChangeListener,
        IVideoPlayerEventsOnCaptionsListListener,
        IVideoPlayerEventsOnCaptionsChangeListener,
        IVideoPlayerEventsOnMetaListener,
        IVideoPlayerEventsOnPlaylistCompleteListener,
        IVideoPlayerEventsOnCompleteListener,
        IAdvertisingEventsOnAdClickListener,
        IAdvertisingEventsOnAdCompleteListener,
        IAdvertisingEventsOnAdSkippedListener,
        IAdvertisingEventsOnAdErrorListener,
        IAdvertisingEventsOnAdImpressionListener,
        IAdvertisingEventsOnAdTimeListener,
        IAdvertisingEventsOnAdPauseListener,
        IAdvertisingEventsOnAdPlayListener,
        IAdvertisingEventsOnBeforePlayListener,
        IAdvertisingEventsOnBeforeCompleteListener
    {

        TextView mOutput;
        public JWEventHandler(JWPlayerView jwPlayerView, TextView output)
        {
            mOutput = output;
            jwPlayerView.AddOnSetupErrorListener(this);
            jwPlayerView.AddOnPlaylistListener(this);
            jwPlayerView.AddOnPlaylistItemListener(this);
            jwPlayerView.AddOnPlayListener(this);
            jwPlayerView.AddOnPauseListener(this);
            jwPlayerView.AddOnBufferListener(this);
            jwPlayerView.AddOnIdleListener(this);
            jwPlayerView.AddOnErrorListener(this);
            jwPlayerView.AddOnSeekListener(this);
            jwPlayerView.AddOnTimeListener(this);
            jwPlayerView.AddOnFullscreenListener(this);
            jwPlayerView.AddOnQualityLevelsListener(this);
            jwPlayerView.AddOnQualityChangeListener(this);
            jwPlayerView.AddOnCaptionsListListener(this);
            jwPlayerView.AddOnCaptionsChangeListener(this);
            jwPlayerView.AddOnAdClickListener(this);
            jwPlayerView.AddOnAdCompleteListener(this);
            jwPlayerView.AddOnAdSkippedListener(this);
            jwPlayerView.AddOnAdErrorListener(this);
            jwPlayerView.AddOnAdImpressionListener(this);
            jwPlayerView.AddOnAdTimeListener(this);
            jwPlayerView.AddOnAdPauseListener(this);
            jwPlayerView.AddOnAdPlayListener(this);
            jwPlayerView.AddOnMetaListener(this);
            jwPlayerView.AddOnPlaylistCompleteListener(this);
            jwPlayerView.AddOnCompleteListener(this);
            jwPlayerView.AddOnBeforePlayListener(this);
            jwPlayerView.AddOnBeforeCompleteListener(this);

        }
        private void UpdateOutput(string output)
        {
            mOutput.Text = output;
        }

        public void OnAudioTrackChange(int currentTrack)
        {
            UpdateOutput("OnAudioTrackChange(" + currentTrack + ")");
        }


        public void OnAudioTracks(IList<AudioTrack> audioTracks)
        {
            UpdateOutput("OnAudioTracks(List<AudioTrack>)");
        }


        public void OnBeforeComplete()
        {
            UpdateOutput("OnBeforeComplete()");
        }


        public void OnBeforePlay()
        {
            UpdateOutput("OnBeforePlay()");
        }


        public void OnBuffer(PlayerState oldState)
        {
            UpdateOutput("OnBuffer(" + oldState + ")");
        }


        public void OnCaptionsChange(int track, IList<Caption> Caption)
        {
            UpdateOutput("OnCaptiOnsChange(" + track + ", List<CaptiOn>)");
        }

        public void OnCaptionsList(IList<Caption> tracks)
        {
            UpdateOutput("OnCaptiOnsList(List<CaptiOn>)");
        }



        public void OnComplete()
        {
            UpdateOutput("OnComplete()");
        }


        public void OnError(string message)
        {
            UpdateOutput("OnError(\"" + message + "\")");
        }


        public void OnFullscreen(bool fullscreen)
        {
            UpdateOutput("OnFullscreen(" + fullscreen + ")");
        }


        public void OnIdle(PlayerState oldState)
        {
            UpdateOutput("OnIdle(" + oldState + ")");
        }


        public void OnMeta(Metadata metadata)
        {
            UpdateOutput("OnMeta(Metadata)");
        }


        public void OnPause(PlayerState oldState)
        {
            UpdateOutput("OnPause(" + oldState + ")");
        }


        public void OnPlay(PlayerState oldState)
        {
            UpdateOutput("OnPlay(" + oldState + ")");
        }


        public void OnPlaylistComplete()
        {
            UpdateOutput("OnPlaylistComplete()");
        }


        public void OnPlaylistItem(int index, PlaylistItem playlistItem)
        {
            UpdateOutput("OnPlaylistItem(" + index + ", PlaylistItem)");
        }


        public void OnPlaylist(IList<PlaylistItem> playlist)
        {
            UpdateOutput("OnPlaylist(List<PlaylistItem>)");
        }


        public void OnQualityChange(int currentQuality)
        {
            UpdateOutput("OnQualityChange(" + currentQuality + ")");
        }


        public void OnQualityLevels(IList<QualityLevel> levels)
        {
            UpdateOutput("OnQualityLevels(List<QualityLevel>)");
        }


        public void OnSeek(int positiOn, int offset)
        {
            UpdateOutput("OnSeek(" + positiOn + ", " + offset + ")");
        }


        public void OnSetupError(string message)
        {
            UpdateOutput("OnSetupError(\"" + message + "\")");
        }


        public void OnTime(long positiOn, long duratiOn)
        {
            // Do nothing - this fires several times per secOnd
        }

        /**
         * Advertising events below here
         */


        public void OnAdClick(string tag)
        {
            UpdateOutput("OnAdClick(\"" + tag + "\")");
        }


        public void OnAdComplete(string tag)
        {
            UpdateOutput("OnAdComplete(\"" + tag + "\")");
        }


        public void OnAdError(string tag, string message)
        {
            UpdateOutput("OnAdError(\"" + tag + "\", \"" + message + "\")");
        }


        public void OnAdImpression(string tag, string creativeType, string adPositiOn)
        {
            UpdateOutput("OnAdImpressiOn(\"" + tag + "\", \"" + creativeType + "\", \"" + adPositiOn + "\")");
        }


        public void OnAdPause(string tag, PlayerState oldState)
        {
            UpdateOutput("OnAdPause(\"" + tag + "\", \"" + oldState + "\")");
        }


        public void OnAdPlay(string tag, PlayerState oldState)
        {
            UpdateOutput("OnAdPlay(\"" + tag + "\", \"" + oldState + "\")");
        }


        public void OnAdSkipped(string tag)
        {
            UpdateOutput("OnAdSkipped(\"" + tag + "\")");
        }


        public void OnAdTime(string tag, long positiOn, long duratiOn, int sequence)
        {
            // Do nothing - this fires several times per secOnd
        }


    }
}