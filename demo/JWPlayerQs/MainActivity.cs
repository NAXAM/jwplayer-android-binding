using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Longtailvideo.Jwplayer;
using Com.Longtailvideo.Jwplayer.Media.Playlists;
using Com.Longtailvideo.Jwplayer.Events.Listeners;
using System;
using Android.Content.Res;
using Android.Views;
using Android.Content.PM;
using Com.Longtailvideo.Jwplayer.Cast;
using Android.Content;

namespace JWPlayerQs
{
    [Activity(Label = "JWPlayerQs", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AppCompatActivity, IVideoPlayerEventsOnFullscreenListener
    {
        JWPlayerView mPlayerView;
        private JWEventHandler mEventHandler;
        private CastManager mCastManager;
        Android.Support.V7.Widget.Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mPlayerView = FindViewById<JWPlayerView>(Resource.Id.jwplayer);
            TextView outputTextView = FindViewById<TextView>(Resource.Id.output);
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            // Handle hiding/showing of ActionBar
            SetSupportActionBar(toolbar);
            mPlayerView.AddOnFullscreenListener(this);

            // Instantiate the JW Player event handler class
            mEventHandler = new JWEventHandler(mPlayerView, outputTextView);

            // Load a media source
            PlaylistItem pi = new PlaylistItem("http://playertest.longtailvideo.com/adaptive/bipbop/gear4/prog_index.m3u8");
            mPlayerView.Load(pi);
            CastManager.Initialize(this);
            mCastManager = CastManager.Instance;
        }


        public override void OnConfigurationChanged(Configuration newConfig)
        {
            // Set fullscreen when the device is rotated to landscape
            mPlayerView.SetFullscreen(newConfig.Orientation == Android.Content.Res.Orientation.Landscape, true);
            base.OnConfigurationChanged(newConfig);
        }


        protected override void OnResume()
        {
            // Let JW Player know that the app has returned from the background
            mPlayerView.OnResume();
            base.OnResume();
        }

        protected override void OnPause()
        {
            mPlayerView.OnPause();
            base.OnPause();
        }


        protected override void OnDestroy()
        {
            // Let JW Player know that the app is being destroyed
            mPlayerView.OnDestroy();
            base.OnDestroy();
        }


        public override bool OnKeyDown(Keycode keyCode, KeyEvent events)
        {
            // Exit fullscreen when the user pressed the Back button
            if (keyCode == Keycode.Back)
            {
                if (mPlayerView.Fullscreen)
                {
                    mPlayerView.SetFullscreen(false, true);
                    return false;
                }
            }
            return base.OnKeyDown(keyCode, events);
        }

        public void OnFullscreen(bool fullscreen)
        {
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            if (actionBar != null)
            {
                if (fullscreen)
                {
                    actionBar.Hide();
                }
                else
                {
                    actionBar.Show();
                }
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_jwplayerview, menu);
            mCastManager.AddMediaRouterButton(menu, Resource.Id.media_route_menu_item);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.switch_to_fragment:
                    Intent i = new Intent(this, typeof(JWPlayerFragmentExample));
                    StartActivity(i);
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

    }
}

