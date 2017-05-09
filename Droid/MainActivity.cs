using System.Threading.Tasks;

using Android.OS;
using Android.App;
using Android.Widget;
using Android.Views.Animations;

namespace WiggleAnimations.Droid
{
    [Activity(Label = "WiggleAnimations.Droid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
			var xamagonImage = FindViewById<ImageView>(Resource.Id.XamagonImageView);
			
			var rotateClockwise10Degrees = AnimationUtils.LoadAnimation(this, Resource.Animation.RotateClockwise10Degrees);
			xamagonImage.StartAnimation(rotateClockwise10Degrees);
        }
    }
}

