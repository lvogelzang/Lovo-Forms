using System;

namespace LovoForms
{
	// Item that represents a form in the overview list in the master page.
	public class MasterPageItem
	{
		public string Label { get; set; }

		public MasterPageItem(String label)
		{
			this.Label = label;
		}
	}
}
