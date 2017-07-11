using System;
using Android.Runtime;
using Java.Util;

namespace Com.Google.Android.Exoplayer.Dash.Mpd
{
    partial class MediaPresentationDescriptionParser
    {
        partial class ContentProtectionsBuilder
        {
            public int Compare(Java.Lang.Object left, Java.Lang.Object right)
            {
                return Compare((Com.Google.Android.Exoplayer.Dash.Mpd.ContentProtection)left, (Com.Google.Android.Exoplayer.Dash.Mpd.ContentProtection)right);
            }
        }
    }
}

namespace Com.Google.Android.Exoplayer.Hls
{
    partial class HlsMediaPlaylist
    {
        partial class Segment
        {
            public int CompareTo(Java.Lang.Object other)
            {
                return CompareTo((Java.Lang.Long)other);
            }
        }
    }
}

namespace Com.Google.Android.Exoplayer.Upstream.Cache
{
    partial class CacheSpan
    {
        public int CompareTo(Java.Lang.Object other)
        {
            return CompareTo((Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan)other);
        }
    }

    partial class LeastRecentlyUsedCacheEvictor
    {
        public int Compare(Java.Lang.Object left, Java.Lang.Object right)
        {
            return Compare((Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan)left, (Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan)right);
        }
    }
}

namespace Com.Google.Android.Exoplayer.Chunk
{
    partial class Format
    {
        partial class DecreasingBandwidthComparator
        {
            public int Compare(Java.Lang.Object left, Java.Lang.Object right)
            {
                return Compare((Com.Google.Android.Exoplayer.Chunk.Format)left, (Com.Google.Android.Exoplayer.Chunk.Format)right);
            }
        }
    }
}

namespace Com.Google.Android.Exoplayer.Metadata.Id3
{
	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='Id3Parser']"
	[global::Android.Runtime.Register("com/google/android/exoplayer/metadata/id3/Id3Parser", DoNotGenerateAcw = true)]
	public sealed partial class Id3Parser : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser
	{

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/google/android/exoplayer/metadata/id3/Id3Parser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(Id3Parser); }
		}

		internal Id3Parser(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='Id3Parser']/constructor[@name='Id3Parser' and count(parameter)=0]"
		[Register(".ctor", "()V", "")]
		public unsafe Id3Parser()
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			try
			{
				if (((object)this).GetType() != typeof(Id3Parser))
				{
					SetHandle(
							global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
				SetHandle(
						global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor);
			}
			finally
			{
			}
		}

		static IntPtr id_canParse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='Id3Parser']/method[@name='canParse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register("canParse", "(Ljava/lang/String;)Z", "")]
		public unsafe bool CanParse(string p0)
		{
			if (id_canParse_Ljava_lang_String_ == IntPtr.Zero)
				id_canParse_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "canParse", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString(p0);
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(native_p0);
				bool __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_canParse_Ljava_lang_String_, __args);
				return __ret;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		static IntPtr id_parse_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='Id3Parser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register("parse", "([BI)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Metadata.Id3.Id3Frame> ParseId3Frame(byte[] p0, int p1)
		{
			if (id_parse_arrayBI == IntPtr.Zero)
				id_parse_arrayBI = JNIEnv.GetMethodID(class_ref, "parse", "([BI)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			try
			{
				JValue* __args = stackalloc JValue[2];
				__args[0] = new JValue(native_p0);
				__args[1] = new JValue(p1);
				global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Metadata.Id3.Id3Frame> __ret = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Metadata.Id3.Id3Frame>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parse_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray(native_p0, p0);
					JNIEnv.DeleteLocalRef(native_p0);
				}
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Google.Android.Exoplayer.Metadata.IMetadataParser
		global::Java.Lang.Object global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser.Parse(byte[] p0, int p1)
		{
            var frames = ParseId3Frame(p0, p1);
            var array = new Java.Util.ArrayList(frames.Count);
            for (int i = 0; i < frames.Count; i++)
            {
                array.Add(frames[i]);
            }

            return array;
		}

	}
}