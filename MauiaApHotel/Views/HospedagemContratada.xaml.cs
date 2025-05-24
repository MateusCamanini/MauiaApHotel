namespace MauiaApHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    App PropriedadesApp;


    public HospedagemContratada()
    {
        InitializeComponent();

        App PropriedadesApp = (App)Application.Current;

        //pck_quarto.ItemsSource= PropriedadesApp.lista_quartos;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            App.Current.MainPage = new ContratacaoDaHospedagem();
        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }




    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}