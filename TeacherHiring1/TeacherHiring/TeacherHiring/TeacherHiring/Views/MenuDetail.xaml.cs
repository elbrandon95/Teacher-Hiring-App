using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.DataBase.Access;
using TeacherHiring.DataBase.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherHiring.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetail : ContentPage
    {
        public string myProperty { get; }
        public string userName { get; }
        public UsuarioDataAccess dataAccess = new UsuarioDataAccess();
        public Usuario usuario = new Usuario();
        public MenuDetail()
        {
            usuario = dataAccess.GetUser();
            InitializeComponent();
            myProperty = "Bienvenido";
            userName = usuario.Nombre;
            BindingContext = this;

            //var map = new Map(
            //    MapSpan.FromCenterAndRadius(
            //            new Position(37, -122), Distance.FromMiles(0.3)))
            //{
            //    IsShowingUser = true,
            //    HeightRequest = 300,
            //    WidthRequest = 400,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalOptions = LayoutOptions.FillAndExpand
            //};


            //Grid grid = new Grid
            //{
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    RowDefinitions =
            //    {
            //        new RowDefinition { Height = GridLength.Auto },
            //        new RowDefinition { Height = GridLength.Auto },
            //    },
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition { Width = GridLength.Auto },
            //    }
            //};


            //grid.Children.Add(map);

            //Content = grid;




        }


    }
    class MenuDetailViewModel : INotifyPropertyChanged
    {
        public string texto;
        public MenuDetailViewModel()
        {
            texto = "vindea pliss";
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