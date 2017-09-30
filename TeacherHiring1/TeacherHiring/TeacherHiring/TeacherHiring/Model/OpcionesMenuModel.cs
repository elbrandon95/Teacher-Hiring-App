using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.Views;

namespace TeacherHiring.Model
{
    public class OpcionesMenuModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string viewName { get; set; }
        public Type TargetType { get; set; }

        public OpcionesMenuModel(int _id, string _text, string _viewName, Type _type)
        {
            this.Id = _id;
            this.Title = _text;
            this.viewName = _viewName;
            this.TargetType = _type;
        }
    }
    class OpcionesMenuMetodo
    {
        public static List<OpcionesMenuModel> getOpcionesMenu(int tipoUsr)
        {
            List<OpcionesMenuModel> opciones = new List<OpcionesMenuModel>();

            if (tipoUsr == 1)
            {
                opciones.Add(new OpcionesMenuModel(1, "Dar Asesoría", "MaestroCursos",typeof(MaestroCursos)));
                opciones.Add(new OpcionesMenuModel(2, "Tus Asesorías", "MaestroCursos", typeof(MaestroCursos)));
            }
            else
            {
                opciones.Add(new OpcionesMenuModel(1, "Buscar Asesoría", "SolicitarAsesoria", typeof(SolicitarAsesoria)));
                opciones.Add(new OpcionesMenuModel(2, "Tus Asesorías", "SolicitarAsesoria", typeof(SolicitarAsesoria)));
            }
            return opciones;
        }
    }
}
