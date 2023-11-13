namespace TrivialApp
{
	internal class Publisher
	{
		public event EventHandler<PublisherArgs>? MessagePublished;

		public string? Name { get; set; } = "Adam";
        public void Publish()
		{
			OnMessagePublished();
		}

		protected virtual void OnMessagePublished()
		{
			MessagePublished.Invoke(this, new PublisherArgs() { PressRelease = "This is the official press release." });
		}
	}
}
