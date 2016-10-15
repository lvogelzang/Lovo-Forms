using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace LovoForms
{
	public partial class Master : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public Master()
		{
			Title = "Forms";
			InitializeComponent();
		}
	}
}
