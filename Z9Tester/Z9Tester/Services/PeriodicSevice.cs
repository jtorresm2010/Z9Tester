using Matcha.BackgroundService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Z9Tester.Services
{
    public class PeriodicSevice : IPeriodicTask
    {
        public TimeSpan Interval { get; set; }
        private int Conteo = 0;

        public async Task<bool> StartJob()
        {
            /*
             
             Codigo ~
             
             */
            //await Task.Delay(1000);
            Conteo++;
            Debug.WriteLine($"~(>'.')> test de Tasks {Conteo}");
            return true;
        }


        public PeriodicSevice(int seconds)
        {
            Interval = TimeSpan.FromSeconds(seconds);
        }
    }
}