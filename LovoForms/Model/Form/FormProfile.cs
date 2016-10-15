using System;

namespace LovoForms
{
	// Profile a form like JobCard, Tag, SpeedyKaizen, etc.
	public class FormProfile
	{
		public string FormName;
		public string FormNamePlural;
		public Type FormType;

		public FormProfile(string formName, string formNamePlural, Type formType)
		{
			FormName = formName;
			FormNamePlural = formNamePlural;
			FormType = formType;
		}
	}
}
