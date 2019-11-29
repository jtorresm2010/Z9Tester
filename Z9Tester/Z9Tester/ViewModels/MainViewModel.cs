using System;
using System.Collections.Generic;
using System.Text;
using Z9Tester.Services;

namespace Z9Tester.ViewModels
{
    public class MainViewModel
    {

        #region Instancias VM
        public AboutViewModel About { get; set; }
        public SearchViewModel Search { get; set; }

        #endregion

        public MainViewModel()
        {
            instance = this;
        }

        //public static MainViewModel Instance { get; } = new MainViewModel();

        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return instance;
        }

    }
}
