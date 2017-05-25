// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WiggleAnimations.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView XamagonImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel XamagonLabel { get; set; }

        [Action ("DeleteButtonTappedUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DeleteButtonTappedUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (DeleteButton != null) {
                DeleteButton.Dispose ();
                DeleteButton = null;
            }

            if (XamagonImageView != null) {
                XamagonImageView.Dispose ();
                XamagonImageView = null;
            }

            if (XamagonLabel != null) {
                XamagonLabel.Dispose ();
                XamagonLabel = null;
            }
        }
    }
}