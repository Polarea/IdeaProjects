using TrivialApp;

Publisher publisher = new Publisher();
Subscriber subscriber = new Subscriber();
publisher.MessagePublished += subscriber.Subscribe;
publisher.Publish();