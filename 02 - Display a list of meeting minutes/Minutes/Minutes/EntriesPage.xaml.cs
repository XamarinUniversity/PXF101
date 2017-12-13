using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minutes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntriesPage : ContentPage
	{
		public EntriesPage ()
		{
			InitializeComponent ();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			entries.ItemsSource = await App.Entries.ReadAsync();
		}
	}
}