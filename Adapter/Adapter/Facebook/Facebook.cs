namespace Adapter.Facebook
{
    class Facebook : IFacevook
    {
        private readonly string _facebookName;
        private readonly int _facebookAge;
        private readonly int _facebookNumberOfFriends;

        public Facebook(string facebookName, int facebookAge, int facebookNumberOfFriends)
        {
            _facebookName = facebookName;
            _facebookAge = facebookAge;
            _facebookNumberOfFriends = facebookNumberOfFriends;
        }

        public string FacebookName
        {
            get { return _facebookName; }
        }
        public int FacebookAge
        {
            get { return _facebookAge; }
        }
        public int FacebookNumberOfFriends
        {
            get { return _facebookNumberOfFriends; }
        }
    }
}
