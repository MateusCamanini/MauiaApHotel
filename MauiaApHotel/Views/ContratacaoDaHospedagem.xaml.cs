namespace MauiaApHotel.Views;

public partial class ContratacaoDaHospedagem : ContentPage
{
	public ContratacaoDaHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//App.Current.MainPage = new HospedagemContratada();//vai para informações do projeto, aterar
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage = new HospedagemContratada();
    }
}