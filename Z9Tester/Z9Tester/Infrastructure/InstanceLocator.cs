using System;
using System.Collections.Generic;
using System.Text;
using Z9Tester.ViewModels;

namespace Z9Tester.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
