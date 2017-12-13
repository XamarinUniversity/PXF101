using System;

namespace Minutes
{
	public class Entry
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public override string ToString()
		{
			return Title + " " + CreatedDate;
		}
	}
}