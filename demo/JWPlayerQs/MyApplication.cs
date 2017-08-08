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
using Com.Longtailvideo.Jwplayer.Cast;

namespace JWPlayerQs
{
   [Application]
    public class MyApplication : Application
    {
        public MyApplication():base()
        {

        }
        public MyApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference,transfer)
        {

        }
        public override void OnCreate()
        { 
            base.OnCreate();
            CastManager.Initialize(this);  
        }
    }
}