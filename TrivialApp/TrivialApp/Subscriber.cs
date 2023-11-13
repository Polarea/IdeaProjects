namespace TrivialApp
{
	internal class Subscriber
	{
		public void Subscribe(object sender, EventArgs e)
		{
			Console.WriteLine(sender + " has recieved the " + e);
		}
	}
}
