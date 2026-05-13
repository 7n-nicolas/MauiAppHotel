using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // É necessário definir a MainPage para o app abrir algo
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            // Definindo dimensões iniciais para Windows/Mac
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}