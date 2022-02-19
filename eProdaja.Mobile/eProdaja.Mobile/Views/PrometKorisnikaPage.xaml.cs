using eProdaja.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrometKorisnikaPage : ContentPage
    {
        private PrometKorisnikaViewModel model;

        public PrometKorisnikaPage()
        {
            InitializeComponent();
            BindingContext = model = new PrometKorisnikaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}