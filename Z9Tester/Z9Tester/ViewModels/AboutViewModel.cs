using GalaSoft.MvvmLight.Command;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using Xamarin.Forms;
using Z9Tester.Services;

namespace Z9Tester.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string title;

        #region MarginValue
        private Thickness marginValueVar;

        public Thickness MarginValue
        {
            get { return marginValueVar; }
            set { SetValue(ref marginValueVar, value); }
        }
        #endregion

        #region MLslider
        private double mLslider;

        public double MLslider
        {
            get { return mLslider; }
            set { SetValue(ref mLslider, value); }
        }
        #endregion

        #region MUslider
        private double mUslider;

        public double MUslider
        {
            get { return mUslider; }
            set { SetValue(ref mUslider, value); }
        }
        #endregion

        #region MRslider
        private double mRslider;

        public double MRslider
        {
            get { return mRslider; }
            set { SetValue(ref mRslider, value); }
        }
        #endregion

        #region MBslider
        private double mBslider;

        public double MBslider
        {
            get { return mBslider; }
            set { SetValue(ref mBslider, value); }
        }
        #endregion

        #region PaddingValue
        private Thickness paddingValue;

        public Thickness PaddingValue
        {
            get { return paddingValue; }
            set { SetValue(ref paddingValue, value); }
        }
        #endregion

        #region PLslider
        private double pLslider;

        public double PLslider
        {
            get { return pLslider; }
            set { SetValue(ref pLslider, value); }
        }
        #endregion

        #region PUslider
        private double pUslider;

        public double PUslider
        {
            get { return pUslider; }
            set { SetValue(ref pUslider, value); }
        }
        #endregion

        #region PRslider
        private double pRslider;

        public double PRslider
        {
            get { return pRslider; }
            set { SetValue(ref pRslider, value); }
        }
        #endregion

        #region PBslider
        private double pBslider;

        public double PBslider
        {
            get { return pBslider; }
            set { SetValue(ref pBslider, value); }
        }
        #endregion

        INotificationManager notificationManager;






        public string Title
        {
            get { return title; }
            set { SetValue(ref title, value); }
        }



        public AboutViewModel()
        {
            Title = "Aplicacion de pruebas";
            var conn = RestService.CheckConnection();
            //var colle = new CollectionView();
            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += OnNotificationReceived;
        }

        private void OnNotificationReceived(object sender, EventArgs e)
        {

            var evtData = (NotificationEventArgs)e;

            Debug.WriteLine($"~(>'.')> {evtData.Title} : {evtData.Message}");
            //ShowNotification(evtData.Title, evtData.Message);
            
        }


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName.Equals("MLslider") || propertyName.Equals("MUslider") || propertyName.Equals("MRslider") || propertyName.Equals("MBslider"))
            {
                MarginValue = new Thickness(MLslider, MUslider, MRslider, MBslider);
            }

            if (propertyName.Equals("PLslider") || propertyName.Equals("PUslider") || propertyName.Equals("PRslider") || propertyName.Equals("PBslider"))
            {
                PaddingValue = new Thickness(PLslider, PUslider, PRslider, PBslider);
            }
        }


        public ICommand OpenWebICommand => new RelayCommand(OpenWebCommand);
        private void OpenWebCommand()
        {
            Device.OpenUri(new Uri("https://xamarin.com/platform"));
        }

        public ICommand TapICommand => new RelayCommand(TapCommand);
        private void TapCommand()
        {
            Debug.WriteLine($"~(>'.')> Tap simple");
        }

        public ICommand LongTapICommand => new RelayCommand(LongTapCommand);
        private void LongTapCommand()
        {
            Debug.WriteLine($"~(>'.')> Tap largo");
        }

        public ICommand SendMessageICommand => new RelayCommand(SendMessageCommand);
        private void SendMessageCommand()
        {
            string title = $"Local Notification ";
            string message = $"You have now received 1 notifications!";
            notificationManager.ScheduleNotification(title, message);
        }

    }
}