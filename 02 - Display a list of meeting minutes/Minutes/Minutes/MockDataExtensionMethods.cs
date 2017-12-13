namespace Minutes
{
    public static class MockDataExtensionMethods
    {
		public static void LoadMockData(this IEntryStore store)
		{
			var a = new Entry() { Title = "Sprint Planning Meeting", Content = "1. Scope 2. Backlog 3. Duration" };
			var b = new Entry() { Title = "Daily Scrum Stand-up", Content = "1. Yesterday 2. Today 3. Impediments" };
			var c = new Entry() { Title = "Sprint Retrospective", Content = "1. Reflection 2. Actions" };

			store.WriteAsync(a).Wait();
			store.WriteAsync(b).Wait();
			store.WriteAsync(c).Wait();
		}
	}
}