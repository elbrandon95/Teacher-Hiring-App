using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TeacherHiring.DataBase.Access;
using TeacherHiring.DataBase.Model;
using System.Windows.Input;

namespace TeacherHiring.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : ContentPage
    {
        public ListView ListView;
        //public string Nombre { get; } = "ASDASD";
        public MenuMaster()
        {
            InitializeComponent();

            BindingContext = new MenuMasterViewModel();
            ListView = MenuItemsListView;
            //nombre = "Izilirng";
        }

        class MenuMasterViewModel : BaseViewModel
        {
            public ObservableCollection<OpcionesMenuModel> MenuItems { get; set; }
            public UsuarioDataAccess usuarioDataAccess = new UsuarioDataAccess();
            public Usuario usuario = new Usuario();
            public string Nombre { get; }
            public string tipoUsr { get; }
            public ICommand CloseCommand { get; set; }
            public MenuMasterViewModel()
            {
                usuario = usuarioDataAccess.GetUser();
                Nombre = usuario.Nombre;
                tipoUsr = usuario.IdTipoPerson == 1 ? "Profesor":"Alumno";
                MenuItems = new ObservableCollection<OpcionesMenuModel>(OpcionesMenuMetodo.getOpcionesMenu(usuario.IdTipoPerson));
                CloseCommand = new Command(async () => await CloseSession());
            }
            async Task CloseSession()
            {
                usuarioDataAccess.DeleteAllUsuario();
                NavigateToCurrentPage(new TeacherHiring.Views.LoginPage());

            }
           
        }
    }
}