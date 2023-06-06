using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class TransactionPage : ContentPage
{
	public TransactionPage()
	{
		InitializeComponent();
		BindingContext = new TransactionsViewModel();
	}

    async void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        var currentVM = (TransactionsViewModel)BindingContext;
        var message = currentVM.SaveTransaction();
        await DisplayAlert("Info", message, "Ok");
        await Navigation.PopToRootAsync();
    }

    async void Cancel_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
