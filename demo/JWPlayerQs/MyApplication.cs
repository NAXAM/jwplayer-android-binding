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
   // [Application(SupportsRtl =true,AllowBackup =true,Theme = "@style/MyTheme",Label ="Appp")]
   // [MetaData("JW_LICENSE_KEY", Value = "upydWUEcObEN/YtMOAIsdPoVbf6vbabPu2vPiw==")]
    public class MyApplication : Application
    {
       
        public override void OnCreate()
        { 
            base.OnCreate();
            CastManager.Initialize(this);  
        }
    }
}