using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Z9Tester.Models;
using Z9Tester.ViewModels;

namespace Z9Tester.Services
{
    class CommentSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = MainViewModel.GetInstance().Search.ListaComentarios
                    .Where(coment => coment.title.ToLower().Contains(newValue.ToLower()))
                    .ToList<MockObject>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            var i = item as MockObject;

            // Note: strings will be URL encoded for navigation (e.g. "Blue Monkey" becomes "Blue%20Monkey"). Therefore, decode at the receiver.
            //await (App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync($"monkeydetails?name={((MockObject)item).title}");
            Debug.WriteLine($"~(>'.')> Item seleccionado {i.title}");
        }
    }
}