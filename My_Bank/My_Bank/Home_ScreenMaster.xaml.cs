using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Bank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home_ScreenMaster : ContentPage
    {
        public ListView ListView;

        public Home_ScreenMaster()
        {
            InitializeComponent();

            BindingContext = new Home_ScreenMasterViewModel();
            ListView = MenuItemsListView;
        }

        class Home_ScreenMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Home_ScreenMenuItem> MenuItems { get; set; }
            
            public Home_ScreenMasterViewModel()
            {
                MenuItems = new ObservableCollection<Home_ScreenMenuItem>(new[]
                {
                    new Home_ScreenMenuItem { Id = 0, Title = "Page 1" },
                    new Home_ScreenMenuItem { Id = 1, Title = "Page 2" },
                    new Home_ScreenMenuItem { Id = 2, Title = "Page 3" },
                    new Home_ScreenMenuItem { Id = 3, Title = "Page 4" },
                    new Home_ScreenMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}