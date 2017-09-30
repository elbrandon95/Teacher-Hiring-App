using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.DataBase.Access;
using TeacherHiring.DataBase.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherHiring.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SolicitarAsesoria : ContentPage
    {
        private MateriaDataAccess dataAccess;
        public Materia materia = new Materia();
        public SolicitarAsesoria()
        {

            dataAccess = new MateriaDataAccess();
            InitializeComponent();
            BindingContext = dataAccess;
        }
    }
}