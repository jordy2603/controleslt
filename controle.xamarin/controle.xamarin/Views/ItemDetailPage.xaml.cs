using controle.xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace controle.xamarin.Views
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