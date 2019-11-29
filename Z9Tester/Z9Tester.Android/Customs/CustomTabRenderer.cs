using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Android.Support.Design.Widget;
using Z9Tester.Customs;
using Z9Tester.Droid.Customs;

//[assembly: ExportRenderer(typeof(CustomTab), typeof(CustomTabRenderer))]
namespace Z9Tester.Droid.Customs
{
    class CustomTabRenderer : TabbedRenderer
    {
        public CustomTabRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                Element.SelectedTabColor = Xamarin.Forms.Color.Azure;


                Console.WriteLine("Test renderer");
                var tab = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
                tab.SetSelectedTabIndicatorColor(Android.Graphics.Color.Blue);
            }
        }
    }
}