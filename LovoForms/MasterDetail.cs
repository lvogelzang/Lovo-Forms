using Xamarin.Forms;

namespace LovoForms
{
	// First page when opening app. Master contains overview of forms, detail views one form.
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail(FormProfile formProfile)
		{
			var masterPage = new Master(formProfile);
			var detailPage = new Detail(formProfile);

			Master = masterPage;
			Detail = new NavigationPage(detailPage);

			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				var navigationPage = Detail as NavigationPage;
				await navigationPage.PopToRootAsync();
				var detailPage = navigationPage.CurrentPage as Detail;
				detailPage.Form = Database.GetFormWithLabel(item.Label);
				IsPresented = false;
			}
		}
	}
}
