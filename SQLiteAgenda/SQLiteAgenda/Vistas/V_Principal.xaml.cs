using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using SQLiteAgenda.Tablas;
using System.IO;
using SQLiteAgenda.Datos;

namespace SQLiteAgenda.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Principal : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public V_Principal()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnBuscar.Clicked += BtnBuscar_Clicked;
            btnRegistrar.Clicked += BtnResgistrar_Clicked;
        }//inicialize

        private void BtnBuscar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var rutaBD = 
 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AgendaSQLite.db3");
                var db = new SQLiteConnection(rutaBD);
                db.CreateTable<T_Contacto>();
                IEnumerable<T_Contacto> resultado = SELECT_WHERE(db, txtNombre.Text);
                if(resultado.Count() > 0)
                {
                    Navigation.PushAsync(new V_Consulta());
                    DisplayAlert("Aviso", "Existen contactos con ese nombre", "OK");
                }
                else
                {
                    DisplayAlert("Aviso", "No existen contactos con ese nombre", "OK");
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static IEnumerable<T_Contacto> SELECT_WHERE(SQLiteConnection db, string nombre)
        {
            return db.Query<T_Contacto>("SELECT * FROM T_Contacto WHERE Nombre=?", nombre);
        }
        private void BtnResgistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new V_Registro());
        }
    }//clase
}//namespace