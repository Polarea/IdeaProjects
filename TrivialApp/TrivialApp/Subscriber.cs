namespace TrivialApp
{
	internal class Subscriber
	{
		public void Subscribe(object sender, PublisherArgs e)
		{
			Console.WriteLine(sender + " Message: " + e.PressRelease);
		}
	}
}
