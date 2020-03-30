using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using SQLiteAgenda.Tablas;
using SQLiteAgenda.Datos;

namespace SQLiteAgenda.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Registro : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public V_Registro()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }//V_Reg
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            var DatosContacto = new T_Contacto { Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text, Telefono = txtTelefono.Text};
            conexion.InsertAsync(DatosContacto);
            limpiarFormulario();
            DisplayAlert("Confirmación","el contacto se registró correctamente","OK");
        }
        void limpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
        }//void
    }//class
}//namespace