using Adapter.Vk;

namespace Adapter.Adapters
{
    class VkAdapter: IAdapter
    {
        private readonly IVk _vk;

        public VkAdapter(IVk vk)
        {
            _vk = vk;
        }

        public string Name {
            get { return _vk.VkName; }
        }
        public int Age {
            get { return _vk.VkAge; }
        }
        public int NumberOfFriends {
            get { return _vk.VkNumberOfFriends; }
        }
    }
}
