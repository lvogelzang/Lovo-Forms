using System.Collections.Generic;
using LovoForms;

namespace LovoForms
{
	public class JobCard : Form
	{
		public int Id { get; }
		public List<List<Property>> Properties { get; }

		public JobCard()
		{
			Id = 0;

			Properties = new List<List<Property>>
			{
				new List<Property> {
					new KeyValueProperty(Resx.JobCards.Title, ""),
					new KeyValueProperty(Resx.JobCards.Revision, ""),
					new KeyValueProperty(Resx.JobCards.FocusArea, ""),
					new KeyValueProperty(Resx.JobCards.NumberOfJobs, "1")
				},
				new List<Property> {
					new KeyValueProperty(Resx.JobCards.Department, ""),
					new KeyValueProperty(Resx.JobCards.InstallationOrArea, ""),
					new KeyValueProperty(Resx.JobCards.MachineOrPlace, ""),
					new KeyValueProperty(Resx.JobCards.Part, ""),
					new KeyValueProperty(Resx.JobCards.SIS, ""),
					new KeyValueProperty(Resx.JobCards.Frequency, ""),
					new KeyValueProperty(Resx.JobCards.Duration, ""),
					new KeyValueProperty(Resx.JobCards.When, "")
				}
			};
		}
	}
}
