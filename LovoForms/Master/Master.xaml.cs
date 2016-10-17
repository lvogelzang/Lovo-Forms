using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace LovoForms
{
	public partial class Master : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public Master(FormProfile formProfile)
		{
			Title = "Forms";
			InitializeComponent();

			listView.ItemsSource = Database.GetMasterPageItems();

			newButton.Text = Resx.App.New + " " + formProfile.FormName;
		}

		public void OnDelete(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
		}

		public void OnNewClicked(object sender, EventArgs e)
		{
			DisplayAlert("Create new job card", "", "OK");
		}
	}
}
