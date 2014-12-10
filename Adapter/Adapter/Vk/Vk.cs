namespace Adapter.Vk
{
    public class Vk : IVk
    {
        private readonly string _vkName;
        private readonly int _vkAge;
        private readonly int _vkNumberOfFriends;

        public Vk(string vkName, int vkAge, int vkNumberOfFriends)
        {
            _vkName = vkName;
            _vkAge = vkAge;
            _vkNumberOfFriends = vkNumberOfFriends;
        }

        public string VkName
        {
            get { return _vkName; }
        }
        public int VkAge {
            get { return _vkAge; }
        }
        public int VkNumberOfFriends {
            get { return _vkNumberOfFriends; }
        }
    }
}
