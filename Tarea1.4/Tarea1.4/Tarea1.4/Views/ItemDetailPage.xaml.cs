using System.ComponentModel;
using Tarea1._4.ViewModels;
using Xamarin.Forms;

namespace Tarea1._4.Views
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