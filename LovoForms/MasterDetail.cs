using Xamarin.Forms;

namespace LovoForms
{
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
