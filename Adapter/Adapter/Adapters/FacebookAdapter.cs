using Adapter.Facebook;
namespace Adapter.Adapters
{
    class FacebookAdapter:IAdapter
    {
        private readonly IFacevook _facebook;

        public FacebookAdapter(IFacevook facebook)
        {
            _facebook = facebook;
        }

        public string Name
        {
            get { return _facebook.FacebookName; }
        }
        public int Age
        {
            get { return _facebook.FacebookAge; }
        }
        public int NumberOfFriends
        {
            get { return _facebook.FacebookNumberOfFriends; }
        }
    }
}
