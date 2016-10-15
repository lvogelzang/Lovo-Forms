using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LovoForms
{
	// TODO: Implement complete database system.
	public abstract class Database
	{
		private static List<String> getAllStoredFormIds()
		{
			return new List<String> { "sk-0-First Speedy Kaizen form", "jc-0-Job Card test" };
		}

		public static List<MasterPageItem> GetMasterPageItems()
		{
			var res = new List<MasterPageItem>();

			foreach (String id in getAllStoredFormIds())
			{
				res.Add(new MasterPageItem(id));
			}
			return res;
		}

		public static Form GetFormWithLabel(String id)
		{
			return new JobCard();
		}
	}
}
