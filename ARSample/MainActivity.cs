using Android.App;
using Android.Widget;
using Android.OS;
using Urho;
using Urho.Actions;
using Urho.Shapes;
using Android.Content.PM;
using Urho.Droid;
using Android.Views;

namespace ARSample
{
	[Activity(Label = "ARSampleZ", MainLauncher = true,
	Icon = "@mipmap/icon", Theme = "@android:style/Theme.NoTitleBar.Fullscreen",
	ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation,
	ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			var mLayout = new AbsoluteLayout(this);
			var surface = UrhoSurface.CreateSurface<ARSample>(this);
			mLayout.AddView(surface);
			SetContentView(mLayout);
		}

		protected override void OnResume()
		{
			UrhoSurface.OnResume();
			base.OnResume();
		}

		protected override void OnPause()
		{
			UrhoSurface.OnPause();
			base.OnPause();
		}

		public override void OnLowMemory()
		{
			UrhoSurface.OnLowMemory();
			base.OnLowMemory();
		}

		protected override void OnDestroy()
		{
			UrhoSurface.OnDestroy();
			base.OnDestroy();
		}

		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (!UrhoSurface.DispatchKeyEvent(e))
				return false;
			return base.DispatchKeyEvent(e);
		}

		public override void OnWindowFocusChanged(bool hasFocus)
		{
			UrhoSurface.OnWindowFocusChanged(hasFocus);
			base.OnWindowFocusChanged(hasFocus);
		}
	}

}


