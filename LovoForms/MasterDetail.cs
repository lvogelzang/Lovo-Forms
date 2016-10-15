using Xamarin.Forms;

namespace LovoForms
{
	// First page when opening app. Master contains overview of forms, detail views one form.
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail()
		{
			var masterPage = new Master();
			var detailPage = new Detail();

			Master = masterPage;
			Detail = new NavigationPage(detailPage);
		}
	}
}
