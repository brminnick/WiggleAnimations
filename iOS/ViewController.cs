using System;
using System.Threading.Tasks;

using UIKit;
using CoreGraphics;

namespace WiggleAnimations.iOS
{
    public partial class ViewController : UIViewController
    {
        const double _animationDuration = 0.3;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

			while (true)
			{
				await Rotate(XamagonImageView, -10);
				await Rotate(XamagonImageView, 20);
				await Rotate(XamagonImageView, -10);
			}
        }

        async Task Rotate(UIView view, nfloat rotationOffsetDegrees)
        {
            nfloat degreesToRadiansConversion = (nfloat)Math.PI / 180;
            var rotation = CGAffineTransform.MakeRotation(degreesToRadiansConversion * rotationOffsetDegrees);

            await UIView.AnimateAsync(_animationDuration, () => view.Transform = rotation);
        }
    }
}
