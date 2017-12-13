using System.Collections.Generic;
using System.Threading.Tasks;

namespace Minutes
{
	public interface IEntryStore
	{
		Task<List<Entry>> ReadAsync();
		Task WriteAsync(Entry entry);
		Task DeleteAsync(Entry entry);
	}
}