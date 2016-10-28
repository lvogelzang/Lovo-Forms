using System.Diagnostics;
using Xamarin.Forms;

namespace LovoForms
{
	public class KeyValueProperty : Property
	{
		private EntryCell _cell;
		public string Key;
		public string Value;

		public KeyValueProperty(string key, string value)
		{
			_cell = new EntryCell();
			Key = key;
			Value = value;
		}

		public Cell getCell()
		{
			_cell.Label = Key;
			_cell.Text = Value;
			return _cell;
		}

		public void registerUpdateEvent(Form form)
		{
			_cell.PropertyChanged += (sender, e) =>
			{
				Value = _cell.Text;
				form.update();
			};
		}
	}
}