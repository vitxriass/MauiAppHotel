
using System.Collections;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        internal IList lista_quartos;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }

    }
}
