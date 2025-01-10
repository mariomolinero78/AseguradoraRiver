using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AseguradoraRiver
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //roles
            var RolLabel = new Label { Text = "Rol:" };
            var CatalogoLabel = new Label { Text = "Catalogo:" };
            var rolesPicker = new Picker();
            rolesPicker.Items.Add("Web Master");
            rolesPicker.Items.Add("Administrador");
            rolesPicker.Items.Add("Ajustador");
            //ID (Int)
            var IDLabel = new Label { Text = "ID:" };
            var IDEntry = new Entry { Placeholder = "0" };
            //Tipos de catalogo (String)
            var tipoCatalogoLabel = new Label { Text = "Tipos de Catalogos:" };
            var tipoCatalogoEntry = new Entry { Placeholder = "Rol" };
            //Origen (String)
            var OrigenLabel = new Label { Text = "Origen:" };
            var OrigenEntry = new Entry { Placeholder = "Activo" };
            //Orden (String)
            var ordenLabel = new Label { Text = "Orden:" };
            var OrdenEntry = new Entry { Placeholder = "" };
            //Default(si o no)
            var defaultLabel = new Label { Text = "Default:" };
            var defaultSwitch = new Switch { IsToggled = false };

            //Valor(int)
            var ValorLabel = new Label { Text = "Valor:" };
            var valorEntry = new Entry { Placeholder = "" };

            //Descripccion(Comentario)
            var descripciónLabel = new Label { Text = "Descripcion:" };
            var descripciónEntry = new Entry { Placeholder = "" };



            // Organizar la interfaz de usuario en un diseño
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(20),
                Spacing = 10,
                Children =
                {
                    RolLabel,
                    CatalogoLabel,
                    rolesPicker,
                    IDLabel,
                    IDEntry,
                    tipoCatalogoLabel,
                    tipoCatalogoEntry,
                    OrigenLabel,
                    OrigenEntry,
                    ordenLabel,
                    OrdenEntry,
                    defaultLabel,
                    defaultSwitch,
                    ValorLabel,
                    valorEntry,
                    descripciónLabel,
                    descripciónEntry


                }
            };

            Content = stackLayout;
        }

        private void EnviarButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
