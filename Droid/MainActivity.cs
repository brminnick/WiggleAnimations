using System.Threading.Tasks;

using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.Views.Animations;
using System;
using WiggleAnimations.Shared;

namespace WiggleAnimations.Droid
{
    [Activity(Label = "WiggleAnimations.Droid", MainLauncher = true)]
    public class MainActivity : Activity, GestureDetector.IOnGestureListener
    {
        #region Constant Fields
        readonly GestureDetector _gestureDetector;
        #endregion

        #region Fields
        bool _isAnimationInProgress;
        ImageView _xamagonImage;
        Button _deleteButton;
        #endregion

        #region Constructors
        public MainActivity() =>
            _gestureDetector = new GestureDetector(this);
        #endregion

        #region Methods
        public override bool OnTouchEvent(MotionEvent e)
        {
            return _gestureDetector.OnTouchEvent(e);
        }

        public bool OnDown(MotionEvent e)
        {
            if (_isAnimationInProgress)
            {
                _deleteButton.Visibility = ViewStates.Invisible;
                _xamagonImage.ClearAnimation();
                _isAnimationInProgress = false;
            }
            else
            {
                _deleteButton.Visibility = ViewStates.Visible;
                _isAnimationInProgress = true;

                var wiggleAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.WiggleAnimation);
                _xamagonImage.StartAnimation(wiggleAnimation);
            }

            return true;
        }

        public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY) => false;
        public void OnLongPress(MotionEvent e) { }
        public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY) => false;
        public void OnShowPress(MotionEvent e) { }
        public bool OnSingleTapUp(MotionEvent e) => false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var xamagonLabel = FindViewById<TextView>(Resource.Id.XamagonLabel);
            _xamagonImage = FindViewById<ImageView>(Resource.Id.XamagonImageView);
            _deleteButton = FindViewById<Button>(Resource.Id.DeleteButton);

            xamagonLabel.Text = LabelConstants.AnimationLabelText;
            _deleteButton.Click += HandleDeleteButtonClick;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            _deleteButton.Click -= HandleDeleteButtonClick;
        }

        void HandleDeleteButtonClick(object sender, EventArgs e)
        {
            _xamagonImage.ClearAnimation();
            _xamagonImage.Visibility = ViewStates.Invisible;
            _deleteButton.Visibility = ViewStates.Invisible;
        }
        #endregion
    }
}

