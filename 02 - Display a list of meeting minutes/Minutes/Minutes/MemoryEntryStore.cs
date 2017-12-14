using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minutes
{
	public class MemoryEntryStore : IEntryStore
	{
		Dictionary<string, Entry> entries = new Dictionary<string, Entry>();

		public Task DeleteAsync(Entry entry)
		{
			entries.Remove(entry.Id);

			return Task.CompletedTask;
		}

		public Task<List<Entry>> ReadAsync()
		{
			var result = entries.Values.ToList();

			return Task.FromResult(result);
		}

		public Task WriteAsync(Entry entry)
		{
			entries[entry.Id] = entry;

			return Task.CompletedTask;
		}
	}
}