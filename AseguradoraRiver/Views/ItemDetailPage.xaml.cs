using System.ComponentModel;
using AseguradoraRiver.ViewModels;
using Xamarin.Forms;

namespace AseguradoraRiver.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}