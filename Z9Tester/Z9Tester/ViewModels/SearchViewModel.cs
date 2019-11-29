using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Z9Tester.Models;
using Z9Tester.Services;

namespace Z9Tester.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        #region Lista de Comentarios
            private ObservableCollection<MockObject> listaCometarios;

            public ObservableCollection<MockObject> ListaComentarios
            {
                get { return listaCometarios; }
                set { SetValue(ref listaCometarios, value); }
            }
        #endregion

        public SearchViewModel()
        {
            GetMockData();
        }

        public async void GetMockData()
        {
            var result = await RestService.GetAsync<List<MockObject>>("https://jsonplaceholder.typicode.com/posts", "", "");

            ListaComentarios = new ObservableCollection<MockObject>(result.Result as List<MockObject>);
        }
    }
}
