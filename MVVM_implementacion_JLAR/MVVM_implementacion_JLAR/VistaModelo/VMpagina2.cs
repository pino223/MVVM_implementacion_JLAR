using MVVM_implementacion_JLAR.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_JLAR.VistaModelo
{
    internal class VMpagina2 : BaseViewModel
    {
        #region
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR 
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }

        #endregion

        #region OBJETOS
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Lucia",
                    Imagen = "https://i.ibb.co/q9MmXv4/bruja.png"
                },
                new Musuarios
                {
                    Nombre = "Nicol",
                    Imagen = "https://i.ibb.co/hZ50Tcj/vispera-de-todos-los-santos.png"
                },
                new Musuarios
                {
                    Nombre = "Profe Miguel",
                    Imagen = "https://i.ibb.co/BggTVM1/grunon.png"
                }
            };
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await ProcesoAsyncrono());
        //public Icommand ProcesoSimpcommand => new command (procesoSimple);
        #endregion
    }
}
