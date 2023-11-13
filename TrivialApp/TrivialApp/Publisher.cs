namespace TrivialApp
{
	internal class Publisher
	{
		public event EventHandler? MessagePublished;
		public void Publish(string str)
		{
			Console.WriteLine(str + " is published!");
			OnMessagePublished();
		}

		protected virtual void OnMessagePublished()
		{
			MessagePublished.Invoke(this, EventArgs.Empty);
		}
	}
}
