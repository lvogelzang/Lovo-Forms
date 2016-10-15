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
					new KeyValueProperty("Title", ""),
					new KeyValueProperty("Revision", ""),
					new KeyValueProperty("FocusArea", ""),
					new KeyValueProperty("NumberOfJobs", "1")
				},
				new List<Property> {
					new KeyValueProperty("Department", ""),
					new KeyValueProperty("InstallationOrArea", ""),
					new KeyValueProperty("MachineOrPlace", ""),
					new KeyValueProperty("Part", "1"),
					new KeyValueProperty("SIS", ""),
					new KeyValueProperty("Frequency", ""),
					new KeyValueProperty("Duration", ""),
					new KeyValueProperty("When", "")
				}
			};
		}
	}
}
