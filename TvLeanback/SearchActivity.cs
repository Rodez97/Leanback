using System;
using Android.App;
using Android.OS;
using AndroidX.Fragment.App;

namespace TvLeanback
{
	[Activity (Label = "SearchActivity", Exported = true)]
	public class SearchActivity: FragmentActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.search);
		}
	}
}

