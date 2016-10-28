using System;
using Xamarin.Forms;

namespace LovoForms
{
	public interface Property
	{
		// Returns table cell that corresponds to property.
		Cell getCell();

		//
		void registerUpdateEvent(Form form);
	}
}
