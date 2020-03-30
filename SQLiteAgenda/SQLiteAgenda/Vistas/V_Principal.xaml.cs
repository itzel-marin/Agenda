using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteAgenda.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Principal : ContentPage
    {
        public V_Principal()
        {
            InitializeComponent();
            btnRegistrar.Clicked += BtnResgistrar_Clicked;
        }//inicialize
        private void BtnResgistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new V_Registro());
        }
    }//clase
}//namespace