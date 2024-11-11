using MVVM_implementacion_JLAR.Modelo;
using MVVM_implementacion_JLAR.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_JLAR.VistaModelo
{
    internal class VMmenuprincipal : BaseViewModel
    {
        #region
        string _Texto;
        public List<Mmenuprincipal> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR 
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }

        #endregion

        #region OBJETOS
        public void Mostrarusuarios()
        {
            listausuarios = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/q9MmXv4/bruja.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a Base de Datos",
                    Icono = "https://i.ibb.co/hZ50Tcj/vispera-de-todos-los-santos.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/BggTVM1/grunon.png"
                }
            };
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if(pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if(pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());

            }
            if(pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new CrudPokemon());

            }

        }
        #endregion
        #region COMANDOS
       // public ICommand Volvercommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
