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
    public partial class V_Detalle : ContentPage
    {
        public V_Detalle(int id, string nom, string ap, string tel)
        {
            InitializeComponent();
        }
    }
}