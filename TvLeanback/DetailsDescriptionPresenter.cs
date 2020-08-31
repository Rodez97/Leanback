using Android.Util;
using AndroidX.Leanback.Widget;
using SupportViewholder = AndroidX.Leanback.Widget.AbstractDetailsDescriptionPresenter.ViewHolder;
namespace TvLeanback
{
	public class DetailsDescriptionPresenter : AbstractDetailsDescriptionPresenter
	{
		protected override void OnBindDescription (ViewHolder viewHolder, Java.Lang.Object item)
		{
			var movie = (Movie)item;
			if (movie != null) {
				Log.Debug ("DetailsDescriptionPresenter", movie.ToString ());
				viewHolder.Title.Text = movie.Title;
				viewHolder.Subtitle.Text = movie.Studio;
				viewHolder.Body.Text = movie.Description;
			} else
				Log.Debug ("DetailsDescriptionPresenter", "movie == null");
		}
	}
}

