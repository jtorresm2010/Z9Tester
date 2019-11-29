using Xamarin.Forms;
using Z9Tester.Droid.Customs;

[assembly: ExportRenderer(typeof(WebView), typeof(WebViewRender))]
namespace Z9Tester.Droid.Customs
{
    using Android.OS;
    using System;
    using Xamarin.Forms.Platform.Android;
    using Android.Content;
    using Android.Webkit;

    public class WebViewRender : WebViewRenderer
    {
        Context _context;
        public WebViewRender(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
                SetupControlSettings();


        }


        //protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        //{
        //    base.OnElementChanged(e);

        //    if (Control != null && e.NewElement != null)
        //        SetupControlSettings();
        //}

        private void SetupControlSettings()
        {
            // Change Settings Here e.g.
            Control.Settings.JavaScriptEnabled = true;

            // Handy Hint: PDF JS will show massive fonts unless the minimum font size is defined as 0. I found this doesn't affect anything else I came across.
            Control.Settings.MinimumFontSize = 0;

            // Android 4.4 and below doesn't respect the ViewPort in HTML
            if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                Control.Settings.UseWideViewPort = true;
        }
    }
}