using Demo1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo1.Views
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