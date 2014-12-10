using Adapter.Twitter;
namespace Adapter.Adapters
{
    class TwitterAdapter:IAdapter
    {
        private readonly ITwitter _twitter;

        public TwitterAdapter(ITwitter twitter)
        {
            _twitter = twitter;
        }

        public string Name
        {
            get { return _twitter.TwitterName; }
        }
        public int Age
        {
            get { return _twitter.TwitterAge; }
        }
        public int NumberOfFriends
        {
            get { return _twitter.TwitterNumberOfFriends; }
        }
    }
}
