using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace LovoForms
{
	public partial class Detail : ContentPage
	{
		/* Command to show form options like delete, duplicate, export etc. */
		private Command _openOptionsCommand;

		/* Holding the current complete form that is being edited. 
		 * Setting the form triggers a reload of the table. */
		Form _Form;
		public Form Form
		{
			get
			{
				return _Form;
			}
			set
			{
				_Form = value;
				_currentProperties = Form.Properties;
				_openOptionsCommand.ChangeCanExecute();
				LoadCells();
			}
		}

		/* Representing the currently visible cells only. */
		private List<List<Property>> _currentProperties;

		public Detail(FormProfile formProfile)
		{
			/* Set the command to display form actions.
 			 * Command is only executable if the form is set. */
			_openOptionsCommand = new Command(async () =>
			{
				var action = await DisplayActionSheet(null, Resx.App.Cancel, Resx.App.Delete, Resx.App.Duplicate, Resx.App.Export);
				Debug.WriteLine("Action: " + action);
			}, () =>
			{
				return Form != null;
			});

			var ActionsItem = new ToolbarItem();
			ActionsItem.Text = Resx.App.Options;
			ActionsItem.Command = _openOptionsCommand;
			ToolbarItems.Add(ActionsItem);

			InitializeComponent();

			// ListView.ItemSelected += OnItemSelected;
		}

		/* Constructor used only when navigating to subcells. In this case, no 
 		 * options toolbaritem is added and only subcells are loaded. */
		public Detail(string title, Form form, List<List<Property>> currentProperties)
		{
			Title = title;
			_Form = form;
			_currentProperties = currentProperties;

			InitializeComponent();

			LoadCells();

			// ListView.ItemSelected += OnItemSelected;
		}

		private void LoadCells()
		{
			if (Form != null && _currentProperties != null)
			{
				var tableRoot = new TableRoot();
				foreach (List<Property> list in _currentProperties)
				{
					var tableSection = new TableSection();
					foreach (Property property in list)
					{
						tableSection.Add(property.getCell());
						property.registerUpdateEvent(Form);
					}
					tableRoot.Add(tableSection);
				}
				tableView.Root = tableRoot;
			}
		}
	}
}
