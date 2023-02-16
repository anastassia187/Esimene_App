using Esimene_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Esimene_App.Views
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