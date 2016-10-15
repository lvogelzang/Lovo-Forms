using System.Collections.Generic;

namespace LovoForms
{
	public interface Form
	{
		int Id { get; }
		List<List<Property>> Properties { get; }
	}
}
