using System.Linq.Expressions;

namespace MauiaApHotel.Views;

public partial class ContratacaoDaHospedagem : ContentPage
{

	public ContratacaoDaHospedagem()
	{
		InitializeComponent();

        App propriedadesApp = (App)Application.Current;
        pck_quarto.ItemsSource = propriedadesApp.lista_quartos;

        dtpck_checin.MinimumDate = DateTime.Now;
        dtpck_checin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checout.MinimumDate = dtpck_checin.MinimumDate.Date.AddDays(1);
        dtpck_checout.MaximumDate = dtpck_checin.MinimumDate.Date.AddMonths(6);


    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            App.Current.MainPage = new NewPage1();
        }
        catch (Exception ex) 
        {

            DisplayAlert("Ops", ex.Message, "OK");
        
        }
        
        
        
    } 

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage = new HospedagemContratada(); 
    }

    private void dtpck_checin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checout.MaximumDate = data_selecionada_checkin.AddMonths(6);

    }
}